package com.longui.lifecycle;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;

public class MainActivity extends Activity {
    private static final String Tag = "lifecycleActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Log.i(Tag, "onCreate");
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    @Override
    protected void onStart() {
        Log.i(Tag, "onStart");
        super.onStart();
    }

    @Override
    protected void onResume() {
        Log.i(Tag, "onResume");
        super.onResume();
    }

    @Override
    protected void onPause() {
        Log.i(Tag, "onPause");
        super.onPause();
    }

    @Override
    protected void onStop() {
        Log.i(Tag, "onStop");
        super.onStop();
    }

    @Override
    protected void onRestart() {
        Log.i(Tag, "onRestart");
        super.onRestart();
    }

    @Override
    protected void onDestroy() {
        Log.i(Tag, "onDestroy");
        super.onDestroy();
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        Log.i(Tag, "onSaveInstanceState");
        super.onSaveInstanceState(outState);
    }

    @Override
    protected void onRestoreInstanceState(Bundle savedInstanceState) {
        Log.i(Tag, "onRestoreInstanceState");
        super.onRestoreInstanceState(savedInstanceState);
    }
}
