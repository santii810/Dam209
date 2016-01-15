package com.longui.notebook.model;

import java.util.ArrayList;

/**
 * Created by longui on 29/10/2015.
 */
public interface NoteRepository {
    public ArrayList<Note> getNotes();
    public void addNote(Note note);
    public void deleteNote(int noteId);
    public Note getNote(int noteId);
}