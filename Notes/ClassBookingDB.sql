CREATE TABLE Country (
    countryID VARCHAR(50) PRIMARY KEY,
    countryName VARCHAR(100) NOT NULL,
    active BIT NOT NULL
);

CREATE TABLE Class (
    classID VARCHAR(50) PRIMARY KEY,
    className VARCHAR(100) NOT NULL,
    classStartDate DATE NOT NULL,
    classCredit DECIMAL(2,0) NOT NULL,
    classPrice DECIMAL(18,2) NOT NULL,
    availableRefundHour INT,  -- Calculated based on classStartDate
    availableSlot INT NOT NULL,
    countryID VARCHAR(50),
    active BIT NOT NULL,
    CONSTRAINT FK_Class_Country FOREIGN KEY (countryID) REFERENCES Country(countryID)
);

CREATE TABLE [User] (
    userID VARCHAR(50) PRIMARY KEY,
    userName VARCHAR(50) NOT NULL,
    userCode VARCHAR(10) UNIQUE NOT NULL,
    password VARCHAR(10) NOT NULL,
    userCredit DECIMAL(18,2) NOT NULL,
    active BIT NOT NULL
);

CREATE TABLE Booking (
    bookingID VARCHAR(50) PRIMARY KEY,
    classID VARCHAR(50),
    userID VARCHAR(50),
    bookingCredit DECIMAL(18,2) NOT NULL,
    bookingStatus VARCHAR(50) NOT NULL CHECK (bookingStatus IN ('booked', 'waitlist', 'cancel', 'closed')),
    bookingSubmitDate DATE NOT NULL,
    bookingCancelDate DATE,
    active BIT NOT NULL,
    CONSTRAINT FK_Booking_Class FOREIGN KEY (classID) REFERENCES Class(classID),
    CONSTRAINT FK_Booking_User FOREIGN KEY (userID) REFERENCES [User](userID)
);