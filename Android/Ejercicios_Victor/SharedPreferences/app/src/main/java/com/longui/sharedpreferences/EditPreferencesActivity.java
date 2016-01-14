package com.longui.sharedpreferences;

import android.content.SharedPreferences;
import android.preference.PreferenceManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;

public class EditPreferencesActivity extends AppCompatActivity {
    private EditText editText;
    private CheckBox checkBox;
    private SharedPreferences preferences;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit_preferences);

        editText = (EditText)findViewById(R.id.userEditText);
        checkBox = (CheckBox)findViewById(R.id.soundCheckBox);

        preferences = getSharedPreferences(
                "preferencias", MODE_PRIVATE);

        editText.setText(preferences.getString("userName", ""));
        checkBox.setChecked(preferences.getBoolean("sound", false));
    }

    public void editButtonClicked(View view) {

        String userName = editText.getText().toString();
        boolean sound = checkBox.isChecked();

        SharedPreferences.Editor editor = preferences.edit();
        editor.putString("userName", userName);
        editor.putBoolean("sound", sound);
        editor.commit();

        finish();
    }
}
