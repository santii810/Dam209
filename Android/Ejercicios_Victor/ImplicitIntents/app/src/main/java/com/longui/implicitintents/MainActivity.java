package com.longui.implicitintents;

import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void webButtonClicked(View view) {
        Intent intent = new Intent(Intent.ACTION_VIEW,
                Uri.parse("http://www.as.com"));
        startActivity(intent);
    }

    public void button2Clicked(View view) {
        Intent intent = new Intent(Intent.ACTION_PICK,
                Uri.parse("content://contacts"));
        startActivity(intent);
    }

    public void button3Clicked(View view) {
        Intent intent = new Intent(Intent.ACTION_VIEW,
                Uri.parse("geo:37.827500,-122.481670"));
        startActivity(intent);
    }
}
