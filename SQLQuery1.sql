CREATE TABLE VehicleImages
(
    image_id     INT IDENTITY(1,1) PRIMARY KEY,
    vehicle_id   INT NOT NULL,
    image_path   NVARCHAR(255) NOT NULL,
    created_at   DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_VehicleImages_Vehicles
    FOREIGN KEY (vehicle_id) REFERENCES Vehicles(vehicle_id)
    ON DELETE CASCADE
);
