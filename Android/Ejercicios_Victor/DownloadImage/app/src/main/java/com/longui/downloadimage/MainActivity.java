package com.longui.downloadimage;

import android.app.ProgressDialog;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ImageView;

import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;

public class MainActivity extends AppCompatActivity {
    ProgressDialog progressDialog;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

//        progressDialog = new ProgressDialog(this);
//        progressDialog.setMessage("Cargando imagen..");
//        progressDialog.setProgressStyle(ProgressDialog.STYLE_SPINNER);
//        progressDialog.show();
        new DownloadImageTask().
                execute("https://cazadebunkers.files.wordpress.com/2013/02/subnorjoy.jpg",
                        "http://www.mayoff.com/5-01cablecarDCP01934.jpg",
                        "http://www.hartiesinfo.net/greybox/Cable_Car_Hartbeespoort.jpg",
                        "http://www.fantom-xp.com/wallpapers/63/San_Francisco_-_Sunset.jpg",
                        "http://travel.roro44.com/europe/france/Paris_France.jpg",
                        "http://designheaven.files.wordpress.com/2010/04/eiffel_tower_paris_france.jpg");
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

    private Bitmap downloadImage(String urlString) {
        return BitmapFactory.decodeStream(openHttpConnection(urlString));
    }

    class DownloadImageTask extends AsyncTask<String, Bitmap, Void> {
        @Override
        protected Void doInBackground(String... params) {
            for (int i = 0; i < params.length; i++) {
                Bitmap bitmap = downloadImage(params[i]);
                try {
                    Thread.sleep(3000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
                if(bitmap != null) {
                    publishProgress(bitmap);
                }
            }

            return null;
        }

        @Override
        protected void onPreExecute() {
            super.onPreExecute();
        }

        @Override
        protected void onPostExecute(Void aVoid) {
            super.onPostExecute(aVoid);
        }

        @Override
        protected void onProgressUpdate(Bitmap... values) {
            ImageView imageView =
                    (ImageView)findViewById(R.id.imageView);
            imageView.setImageBitmap(values[0]);
        }
    }
}
