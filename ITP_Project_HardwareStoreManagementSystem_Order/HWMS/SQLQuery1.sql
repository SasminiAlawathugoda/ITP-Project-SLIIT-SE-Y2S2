
CREATE TABLE Bill(
billID varchar(20),
transactionID varchar(20),
billDate date,
billTime time,
itemID int,
quantity int,
total real,
CONSTRAINT billPK PRIMARY KEY (billID)
);


CREATE TABLE CustomerOrder(
orderID varchar(20),
transactionID varchar(20),
dateOfOrder date,
timeOfOrder time,
itemID int,
quantity int,
orderDestination varchar(50),
CONSTRAINT orderDetailsPK PRIMARY KEY (orderID)
);

CREATE TABLE SupplierOrder(
orderID varchar(20),
transactionID varchar(20),
dateOfOrder date,
timeOfOrder time,
itemID int,
quantity int,
CONSTRAINT sorderDetailsPK PRIMARY KEY (orderID)
);
