package com.longui.notebook;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.TextView;

import com.longui.notebook.model.Note;

public class AddNoteActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_note);
    }

    public void saveButtonClicked(View view) {
        String title = ((TextView)findViewById(R.id.titleEditText)).
                getText().toString();
        String text = ((TextView)findViewById(R.id.textEditText)).
                getText().toString();
        Note note = new Note(text, title);
        NotebookApp.getNoteRepository().addNote(note);

        finish();
    }
}
