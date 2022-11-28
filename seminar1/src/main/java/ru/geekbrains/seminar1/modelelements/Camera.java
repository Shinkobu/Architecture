package ru.geekbrains.seminar1.modelelements;

public class Camera {

    Collection <Point3D> location;
    Collection <Angle3D> angle;

    public void rotate(Angle3D angle3D) {
        //todo
    }

    public Collection<Point3D> getLocation() {
        return location;
    }

    public void setLocation(Collection<Point3D> location) {
        this.location = location;
    }

    public Collection<Angle3D> getAngle() {
        return angle;
    }

    public void setAngle(Collection<Angle3D> angle) {
        this.angle = angle;
    }

    public void move(Point3D point3D) {
        //todo
    }

    public Camera(Collection<Point3D> location, Collection<Angle3D> angle) {
        this.location = location;
        this.angle = angle;
    }
}
