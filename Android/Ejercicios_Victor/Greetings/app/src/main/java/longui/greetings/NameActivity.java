package longui.greetings;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;

public class NameActivity extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_name);
    }

    public void acceptButtonClicked(View view) {
        EditText editText = (EditText)findViewById(R.id.nameEditText);
        String name = editText.getText().toString();

        Intent intent = new Intent(this, GreetingsActivity.class);
        intent.putExtra("name", name);
        startActivity(intent);
    }
}
