package ru.geekbrains.seminar1.inmemorymodel;

public interface ModelChanger {


    void RegisterModelChanger(ModelChangedObserver o);
    void RemoveModelChanger(ModelChangedObserver o);
    void NotifyChange();
}
