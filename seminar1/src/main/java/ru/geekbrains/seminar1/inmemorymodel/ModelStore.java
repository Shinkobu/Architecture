package ru.geekbrains.seminar1.inmemorymodel;

import java.util.ArrayList;
import java.util.Collection;

public class ModelStore implements ModelChanger {

    public Collection <PoligonalModel> models;
    public Collection <Scene> scenes;
    public Collection <Flash> flashes;
    public Collection <Camera> cameras;

    public Scene getScena(int someInt) {

    }

    private Collection<ModelChangedObserver> changeObservers = new ArrayList<>();

    @Override
    public void RegisterModelChanger(ModelChangedObserver o) {

    }

    @Override
    public void RemoveModelChanger(ModelChangedObserver o) {

    }

    public Collection<PoligonalModel> getModels() {
        return models;
    }

    public void setModels(Collection<PoligonalModel> models) {
        this.models = models;
    }

    public Collection<Scene> getScenes() {
        return scenes;
    }

    public void setScenes(Collection<Scene> scenes) {
        this.scenes = scenes;
    }

    public Collection<Flash> getFlashes() {
        return flashes;
    }

    public void setFlashes(Collection<Flash> flashes) {
        this.flashes = flashes;
    }

    public Collection<Camera> getCameras() {
        return cameras;
    }

    public void setCameras(Collection<Camera> cameras) {
        this.cameras = cameras;
    }

    public Collection<ModelChangedObserver> getChangeObservers() {
        return changeObservers;
    }

    public void setChangeObservers(Collection<ModelChangedObserver> changeObservers) {
        this.changeObservers = changeObservers;
    }

    @Override
    public void NotifyChange(ModelChanger modelChanger) {

    }
}
