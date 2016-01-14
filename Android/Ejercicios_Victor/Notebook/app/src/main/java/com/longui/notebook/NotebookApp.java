package com.longui.notebook;

import android.app.Application;
import android.os.Environment;

import com.longui.notebook.model.MemoryNoteRepository;
import com.longui.notebook.model.NoteRepository;
import com.longui.notebook.model.SQLiteNoteRepository;
import com.longui.notebook.model.XmlNoteRepository;

/**
 * Created by VíctorManuel on 23/10/2015.
 */
public class NotebookApp extends Application {
    private static NoteRepository noteRepository;

    public static NoteRepository getNoteRepository() {
        return noteRepository;
    }

    public NotebookApp() {
        super();
    }

    @Override
    public void onCreate() {
        super.onCreate();

        noteRepository = new SQLiteNoteRepository(this);
        //noteRepository = new XmlNoteRepository(getFilesDir());
        //noteRepository = new MemoryNoteRepository();
    }
}
