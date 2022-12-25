package ru.geekbrains.lesson6.databases;

import ru.geekbrains.lesson6.notes.infrastructure.Database;

public class NotesDatabase implements Database {

    private NotesTable notesTable = new NotesTable();

    public NotesTable getNotesTable() {
        return notesTable;
    }
}
