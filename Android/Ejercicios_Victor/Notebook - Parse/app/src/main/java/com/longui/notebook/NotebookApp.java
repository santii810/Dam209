package com.longui.notebook;

import android.app.Application;

import com.longui.notebook.model.NoteRepository;
import com.longui.notebook.model.ParseNoteRepository;

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

        noteRepository = new ParseNoteRepository(this);
    }
}
