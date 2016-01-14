package longui.uisamples;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.ImageButton;
import android.widget.RadioGroup;
import android.widget.Toast;
import android.widget.ToggleButton;

public class BasicViewsActivity extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        final int valor = 5;

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_basic_views);

        Button b = (Button)findViewById(R.id.button);
        b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(getBaseContext(),
                        "Botón pulsado", Toast.LENGTH_LONG).show();
            }
        });

        ImageButton imageButton =
                (ImageButton)findViewById(R.id.imageButton);
        imageButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(getBaseContext(),
                        "Botón de imagen pulsado " + valor, Toast.LENGTH_LONG).show();
            }
        });

        CheckBox checkBox =
                (CheckBox)findViewById(R.id.checkBox);
        checkBox.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(((CheckBox)v).isChecked()) {
                    Toast.makeText(getBaseContext(),
                            "Checkbox marcado", Toast.LENGTH_LONG).show();
                }
                else {
                    Toast.makeText(getBaseContext(),
                            "Checkbox desmarcado", Toast.LENGTH_LONG).show();
                }
            }
        });

        CheckBox starCheckBox =
                (CheckBox)findViewById(R.id.starCheckBox);
        starCheckBox.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(((CheckBox)v).isChecked()) {
                    Toast.makeText(getBaseContext(),
                            "Checkbox estrella marcado", Toast.LENGTH_LONG).show();
                }
                else {
                    Toast.makeText(getBaseContext(),
                            "Checkbox estrella desmarcado", Toast.LENGTH_LONG).show();
                }
            }
        });

        RadioGroup radioGroup =
                (RadioGroup)findViewById(R.id.radioGroup);
        radioGroup.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup group, int checkedId) {
                if (checkedId == findViewById(R.id.radioButton).getId()) {
                    Toast.makeText(getBaseContext(),
                            "Radio 1 marcado", Toast.LENGTH_LONG).show();
                } else {
                    Toast.makeText(getBaseContext(),
                            "Radio 2 marcado", Toast.LENGTH_LONG).show();
                }
            }
        });

        ToggleButton toggleButton =
                (ToggleButton)findViewById(R.id.toggleButton);
        toggleButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (((ToggleButton) v).isChecked()) {
                    Toast.makeText(getBaseContext(),
                            "Botón toggle marcado", Toast.LENGTH_LONG).show();
                } else {
                    Toast.makeText(getBaseContext(),
                            "Botón toggle desmarcado", Toast.LENGTH_LONG).show();
                }
            }
        });
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_basic_views, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
