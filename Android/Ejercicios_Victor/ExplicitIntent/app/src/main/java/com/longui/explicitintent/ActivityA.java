package com.longui.explicitintent;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class ActivityA extends AppCompatActivity {
    private static int RequestCode = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_a);
    }

    public void buttonToBClicked(View view) {
        Intent intent = new Intent(this, ActivityB.class);
        EditText editText = (EditText)findViewById(R.id.editTextA);
        intent.putExtra("text", editText.getText().toString());

        startActivityForResult(intent, RequestCode);
    }

    @Override
    protected void onActivityResult(
            int requestCode, int resultCode, Intent data) {
        if(requestCode == RequestCode && resultCode == RESULT_OK) {
            TextView textView = (TextView)findViewById(R.id.textViewA);
            textView.setText(data.getStringExtra("returnText"));
        }
    }
}
