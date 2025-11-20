-- Table: clients
INSERT INTO clients (first_name, last_name, phone, email) 
VALUES ('John', 'Smith', '1234567890', 'john.smith@example.com');

INSERT INTO clients (first_name, last_name, phone, email) 
VALUES ('Emma', 'Johnson', '0987654321', 'emma.johnson@example.com');

INSERT INTO clients (first_name, last_name, phone, email) 
VALUES ('Liam', 'Brown', '1122334455', 'liam.brown@example.com');

INSERT INTO clients (first_name, last_name, phone, email) 
VALUES ('Olivia', 'Davis', '2233445566', 'olivia.davis@example.com');

INSERT INTO clients (first_name, last_name, phone, email) 
VALUES ('Noah', 'Wilson', '3344556677', 'noah.wilson@example.com');


-- Table: employees
INSERT INTO employees (first_name, last_name, position, phone, email, hire_date, salary) 
VALUES ('Alice', 'Miller', 'Manager', '1112223333', 'alice.miller@example.com', TO_DATE('2020-01-15', 'YYYY-MM-DD'), 15000.00);

INSERT INTO employees (first_name, last_name, position, phone, email, hire_date, salary) 
VALUES ('Robert', 'Anderson', 'Cashier', '4445556666', 'robert.anderson@example.com', TO_DATE('2019-05-20', 'YYYY-MM-DD'), 12000.00);

INSERT INTO employees (first_name, last_name, position, phone, email, hire_date, salary) 
VALUES ('Sophia', 'Thomas', 'Consultant', '7778889999', 'sophia.thomas@example.com', TO_DATE('2021-03-10', 'YYYY-MM-DD'), 13000.00);

INSERT INTO employees (first_name, last_name, position, phone, email, hire_date, salary) 
VALUES ('James', 'Taylor', 'Assistant', '8889990000', 'james.taylor@example.com', TO_DATE('2022-08-01', 'YYYY-MM-DD'), 11000.00);

INSERT INTO employees (first_name, last_name, position, phone, email, hire_date, salary) 
VALUES ('Isabella', 'Moore', 'Agent', '9990001111', 'isabella.moore@example.com', TO_DATE('2023-02-25', 'YYYY-MM-DD'), 14000.00);


-- Table: tours
INSERT INTO tours (tour_name, destination, start_date, end_date, price) 
VALUES ('Sunny Spain', 'Spain', TO_DATE('2025-06-10', 'YYYY-MM-DD'), TO_DATE('2025-06-20', 'YYYY-MM-DD'), 25000.00);

INSERT INTO tours (tour_name, destination, start_date, end_date, price) 
VALUES ('Alpine Adventure', 'Austria', TO_DATE('2025-01-05', 'YYYY-MM-DD'), TO_DATE('2025-01-12', 'YYYY-MM-DD'), 18000.00);

INSERT INTO tours (tour_name, destination, start_date, end_date, price) 
VALUES ('Romantic Paris', 'France', TO_DATE('2025-04-01', 'YYYY-MM-DD'), TO_DATE('2025-04-10', 'YYYY-MM-DD'), 22000.00);

INSERT INTO tours (tour_name, destination, start_date, end_date, price) 
VALUES ('Luxury Dubai', 'UAE', TO_DATE('2025-09-15', 'YYYY-MM-DD'), TO_DATE('2025-09-25', 'YYYY-MM-DD'), 30000.00);

INSERT INTO tours (tour_name, destination, start_date, end_date, price) 
VALUES ('Swiss Relax', 'Switzerland', TO_DATE('2025-12-01', 'YYYY-MM-DD'), TO_DATE('2025-12-08', 'YYYY-MM-DD'), 27000.00);


-- Table: hotels
INSERT INTO hotels (hotel_name, location, stars, phone, email, tour_id) 
VALUES ('Ocean View Hotel', 'Barcelona', 5, '1112223344', 'info@oceanview.com', 1);

INSERT INTO hotels (hotel_name, location, stars, phone, email, tour_id) 
VALUES ('Alpine Lodge', 'Innsbruck', 4, '2223334455', 'contact@alpinelodge.com', 2);

INSERT INTO hotels (hotel_name, location, stars, phone, email, tour_id) 
VALUES ('City Central', 'Paris', 3, '3334445566', 'hello@citycentral.com', 3);

INSERT INTO hotels (hotel_name, location, stars, phone, email, tour_id) 
VALUES ('Desert Oasis', 'Dubai', 5, '4445556677', 'info@desertoasis.com', 4);

INSERT INTO hotels (hotel_name, location, stars, phone, email, tour_id) 
VALUES ('Green Hills Resort', 'Zurich', 4, '5556667788', 'stay@greenhills.com', 5);


-- Table: meals
INSERT INTO meals (tour_id, meal_type, description) 
VALUES (1, 'Breakfast', 'Continental breakfast in hotel');

INSERT INTO meals (tour_id, meal_type, description) 
VALUES (2, 'Full Board', 'Breakfast, lunch and dinner included');

INSERT INTO meals (tour_id, meal_type, description) 
VALUES (3, 'Half Board', 'Breakfast and dinner included');

INSERT INTO meals (tour_id, meal_type, description) 
VALUES (4, 'All Inclusive', 'All meals and drinks included');

INSERT INTO meals (tour_id, meal_type, description) 
VALUES (5, 'No Meals', 'Meals not included in price');


-- Table: passport
INSERT INTO passport (client_id, passport_number, issue_date, expiry_date, issuing_country) 
VALUES (1, 'AB123456', TO_DATE('2018-01-01', 'YYYY-MM-DD'), TO_DATE('2028-01-01', 'YYYY-MM-DD'), 'USA');

INSERT INTO passport (client_id, passport_number, issue_date, expiry_date, issuing_country) 
VALUES (2, 'CD654321', TO_DATE('2019-02-15', 'YYYY-MM-DD'), TO_DATE('2029-02-15', 'YYYY-MM-DD'), 'USA');

INSERT INTO passport (client_id, passport_number, issue_date, expiry_date, issuing_country) 
VALUES (3, 'EF112233', TO_DATE('2020-03-20', 'YYYY-MM-DD'), TO_DATE('2030-03-20', 'YYYY-MM-DD'), 'USA');

INSERT INTO passport (client_id, passport_number, issue_date, expiry_date, issuing_country) 
VALUES (4, 'GH445566', TO_DATE('2021-04-25', 'YYYY-MM-DD'), TO_DATE('2031-04-25', 'YYYY-MM-DD'), 'USA');

INSERT INTO passport (client_id, passport_number, issue_date, expiry_date, issuing_country) 
VALUES (5, 'IJ778899', TO_DATE('2022-05-30', 'YYYY-MM-DD'), TO_DATE('2032-05-30', 'YYYY-MM-DD'), 'USA');


-- Table: transport
INSERT INTO transport (transport_type, route_number, departure_date, departure_time, departure_place, arrival_place, price, employee_id, tour_id) 
VALUES ('Plane', 'FR5678', TO_DATE('2025-06-10', 'YYYY-MM-DD'), TO_TIMESTAMP('2025-06-10 08:30:00', 'YYYY-MM-DD HH24:MI:SS'), 'Kyiv', 'Barcelona', 4000.00, 1, 1);

INSERT INTO transport (transport_type, route_number, departure_date, departure_time, departure_place, arrival_place, price, employee_id, tour_id) 
VALUES ('Bus', 'ALP123', TO_DATE('2025-01-05', 'YYYY-MM-DD'), TO_TIMESTAMP('2025-01-05 06:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'Kyiv', 'Innsbruck', 3000.00, 2, 2);

INSERT INTO transport (transport_type, route_number, departure_date, departure_time, departure_place, arrival_place, price, employee_id, tour_id) 
VALUES ('Train', 'EU789', TO_DATE('2025-04-01', 'YYYY-MM-DD'), TO_TIMESTAMP('2025-04-01 10:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'Kyiv', 'Paris', 3500.00, 3, 3);

INSERT INTO transport (transport_type, route_number, departure_date, departure_time, departure_place, arrival_place, price, employee_id, tour_id) 
VALUES ('Plane', 'DXB900', TO_DATE('2025-09-15', 'YYYY-MM-DD'), TO_TIMESTAMP('2025-09-15 14:30:00', 'YYYY-MM-DD HH24:MI:SS'), 'Kyiv', 'Dubai', 4500.00, 4, 4);

INSERT INTO transport (transport_type, route_number, departure_date, departure_time, departure_place, arrival_place, price, employee_id, tour_id) 
VALUES ('Plane', 'ZRH456', TO_DATE('2025-12-01', 'YYYY-MM-DD'), TO_TIMESTAMP('2025-12-01 09:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'Kyiv', 'Zurich', 4200.00, 5, 5);


-- Table: bookings
INSERT INTO bookings (booking_date, client_id, tour_id, employee_id) 
VALUES (TO_DATE('2025-03-01', 'YYYY-MM-DD'), 1, 1, 1);

INSERT INTO bookings (booking_date, client_id, tour_id, employee_id) 
VALUES (TO_DATE('2025-02-15', 'YYYY-MM-DD'), 2, 2, 2);

INSERT INTO bookings (booking_date, client_id, tour_id, employee_id) 
VALUES (TO_DATE('2025-03-10', 'YYYY-MM-DD'), 3, 3, 3);

INSERT INTO bookings (booking_date, client_id, tour_id, employee_id) 
VALUES (TO_DATE('2025-04-05', 'YYYY-MM-DD'), 4, 4, 4);

INSERT INTO bookings (booking_date, client_id, tour_id, employee_id) 
VALUES (TO_DATE('2025-05-20', 'YYYY-MM-DD'), 5, 5, 5);


-- Table: payments
INSERT INTO payments (booking_id, amount, payment_date, transaction_number, payment_method, employee_id) 
VALUES (1, 29000.00, TO_DATE('2025-03-02', 'YYYY-MM-DD'), 'TXN100001', 'Card', 1);

INSERT INTO payments (booking_id, amount, payment_date, transaction_number, payment_method, employee_id) 
VALUES (2, 21000.00, TO_DATE('2025-02-16', 'YYYY-MM-DD'), 'TXN100002', 'Cash', 2);

INSERT INTO payments (booking_id, amount, payment_date, transaction_number, payment_method, employee_id) 
VALUES (3, 25000.00, TO_DATE('2025-03-11', 'YYYY-MM-DD'), 'TXN100003', 'Bank Transfer', 3);

INSERT INTO payments (booking_id, amount, payment_date, transaction_number, payment_method, employee_id) 
VALUES (4, 32000.00, TO_DATE('2025-04-06', 'YYYY-MM-DD'), 'TXN100004', 'Card', 4);

INSERT INTO payments (booking_id, amount, payment_date, transaction_number, payment_method, employee_id) 
VALUES (5, 31000.00, TO_DATE('2025-05-21', 'YYYY-MM-DD'), 'TXN100005', 'Cash', 5);