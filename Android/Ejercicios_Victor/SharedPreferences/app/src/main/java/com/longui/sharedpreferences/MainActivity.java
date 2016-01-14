package com.longui.sharedpreferences;

import android.content.Intent;
import android.preference.PreferenceActivity;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void editButtonClicked(View view) {
        Intent intent = new Intent(this,
                EditPreferencesActivity.class);
        startActivity(intent);
    }

    public void preferencesButtonClicked(View view) {
        Intent intent = new Intent(this,
                PreferencesActivity.class);
        startActivity(intent);
    }
}
