package longui.ejercicioui;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    private CheckBox checkBox1;
    private CheckBox checkBox2;
    private CheckBox checkBox3;
    private CheckBox checkBox4;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        checkBox1 = (CheckBox)
                findViewById(R.id.checkBox1);
        checkBox1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(getBaseContext(),
                        "El estado del CheckBox 1 ha cambiado",
                        Toast.LENGTH_SHORT).show();
            }
        });

        checkBox2 = (CheckBox)
                findViewById(R.id.checkBox2);
        checkBox2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(getBaseContext(),
                        "El estado del CheckBox 2 ha cambiado",
                        Toast.LENGTH_SHORT).show();
            }
        });

        checkBox3 = (CheckBox)
                findViewById(R.id.checkBox3);
        checkBox3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(getBaseContext(),
                        "El estado del CheckBox 3 ha cambiado",
                        Toast.LENGTH_SHORT).show();
            }
        });

        checkBox4 = (CheckBox)
                findViewById(R.id.checkBox4);
        checkBox4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Toast.makeText(getBaseContext(),
                        "El estado del CheckBox 4 ha cambiado",
                        Toast.LENGTH_SHORT).show();
            }
        });
    }

    public void button2Clicked(View view) {
        checkBox1.setChecked(false);
        checkBox2.setChecked(false);
        checkBox3.setChecked(false);
        checkBox4.setChecked(false);
    }

    public void button1Clicked(View view) {
        Intent intent = new Intent(this, GreenActivity.class);
        startActivity(intent);
    }
}
