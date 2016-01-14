package com.longui.notebook.model;

import java.util.ArrayList;

/**
 * Created by longui on 29/10/2015.
 */
public class MemoryNoteRepository implements NoteRepository {
    private ArrayList<Note> notes;
    private int currentId;

    public MemoryNoteRepository() {
        notes = new ArrayList<>();
        currentId = 1;

        Note note = new Note("Nota 1", "Esto es la nota 1");
        addNote(note);

        note = new Note("Nota 2", "Esto es la nota 2");
        addNote(note);

        note = new Note("Nota 3", "Esto es la nota 3");
        addNote(note);
    }

    @Override
    public ArrayList<Note> getNotes() {
        return notes;
    }

    @Override
    public void addNote(Note note) {
        note.setId(currentId++);
        notes.add(note);
    }

    @Override
    public void deleteNote(int noteId) {
        notes.remove(getNote(noteId));
    }

    @Override
    public Note getNote(int noteId) {
        for (Note note : notes) {
            if(note.getId() == noteId) {
                return note;
            }
        }

        return null;
    }
}
