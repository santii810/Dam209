package com.longui.files;

import android.os.Environment;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class MainActivity extends AppCompatActivity {
    EditText editText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        editText = (EditText)findViewById(R.id.editText);
    }

    public void saveButtonClicked(View view) {
        String text = editText.getText().toString();

        try {
            //FileOutputStream fos = openFileOutput("datos.txt",
            //        MODE_PRIVATE);
            File sd = Environment.getExternalStorageDirectory();
            File folder = new File(sd.getAbsolutePath() +
                    File.separator + "datos");
            folder.mkdir();
            File file = new File(folder, "datossd.txt");
            FileOutputStream fos = new FileOutputStream(file);

            OutputStreamWriter osw = new OutputStreamWriter(fos);

            osw.write(text);
            osw.flush();
            osw.close();
            fos.close();

            Toast.makeText(this, "Fichero guardado correctamente",
                    Toast.LENGTH_SHORT).show();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public void loadButtonClicked(View view) {
        try {
            FileInputStream fis = openFileInput("datos.tx");
            InputStreamReader isr = new InputStreamReader(fis);
            BufferedReader br = new BufferedReader(isr);

            String text = "";
            String line;
            while((line = br.readLine()) != null) {
                text += line;
            }

            editText.setText(text);
            br.close();
            isr.close();
            fis.close();
        } catch (IOException e) {
            Toast.makeText(this, "No se encuentra el fichero",
                    Toast.LENGTH_SHORT).show();
        }
    }
}
