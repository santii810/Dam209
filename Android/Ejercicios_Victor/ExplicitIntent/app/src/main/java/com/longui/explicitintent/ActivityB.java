package com.longui.explicitintent;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class ActivityB extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_b);

        TextView textView = (TextView)findViewById(R.id.textViewB);
        textView.setText(getIntent().getStringExtra("text"));
    }

    public void buttonToAClicked(View view) {
        EditText editText = (EditText)findViewById(R.id.editTextB);

        Intent result = new Intent();
        result.putExtra("returnText", editText.getText().toString());
        setResult(RESULT_OK, result);

        finish();
    }
}
