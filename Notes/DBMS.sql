Class
- classID varchar(50)
- className varchar(100)
- classStartDate Date
- classCredit decimal(2,0)
- classPrice decimal(18,2)
- availableRefundHour int -- calculate from classStartDate
- availableSlot int
- countryID varchar(50)
- active bool

Country
- countryID varchar(50)
- countryName varchar(100)
- active bool

Booking
- bookingID varchar(50)
- classID varchar(50)
- userID varchar(50)
- bookingCredit decimal(18,2)
- bookingStatus varchar(50) --booked, waitlist, cancel, closed
- bookingSubmitDate Date
- bookingCancelDate Date
- active bool

User
- userID varchar(50)
- userName varchar(50)
- userCode varchar(10) --distinct
- password varchar(10)
- userCredit decimal(18,2)
- active bool