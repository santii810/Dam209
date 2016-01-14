package com.longui.xmlservice;

import android.graphics.Bitmap;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        new DownloadXmlTask().execute(
                "http://extjs.org.cn/extjs/examples/grid/survey.html");
    }

    private InputStream openHttpConnection(String urlString) {
        InputStream is = null;
        int responseCode;

        URL url = null;
        try {
            url = new URL(urlString);
            HttpURLConnection connection =
                    (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("GET");
            connection.setInstanceFollowRedirects(true);
            connection.connect();
            responseCode = connection.getResponseCode();

            if(responseCode == HttpURLConnection.HTTP_OK) {
                is = connection.getInputStream();
            }
        } catch (MalformedURLException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        return is;
    }

    private String downloadText(String urlString) {
        InputStreamReader isr =
                new InputStreamReader(openHttpConnection(urlString));
        BufferedReader br = new BufferedReader(isr);

        String xml = "";
        String line;
        try {
            while((line = br.readLine()) != null) {
                xml += line + "\n";
            }

            br.close();
            isr.close();
        } catch (IOException e) {
            e.printStackTrace();
        }

        return xml;
    }

    private String[] getData(String jsonData) {
        try {
            JSONArray jsonArray = new JSONArray(jsonData);
            JSONObject object = jsonArray.getJSONObject(0);
            String[] data = {object.getString("surveyDate"),
                    object.getString("surveyTime")};

            return data;
        } catch (JSONException e) {
            e.printStackTrace();
        }

        return null;
    }

    class DownloadXmlTask extends AsyncTask<String, Void, String> {
        @Override
        protected String doInBackground(String... params) {
            return downloadText(params[0]);
        }

        @Override
        protected void onPostExecute(String s) {
            TextView textView = (TextView)findViewById(R.id.textView);

            String[] data = getData(s);

            textView.setText("Fecha: " + data[0] +
                    "\n" + "Hora: " + data[1]);
        }
    }
}
