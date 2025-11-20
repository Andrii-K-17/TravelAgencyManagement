-- bookings: зовнішні ключі
CREATE INDEX idx_bookings_client_id ON bookings (client_id);
CREATE INDEX idx_bookings_employee_id ON bookings (employee_id);
CREATE INDEX idx_bookings_tour_id ON bookings (tour_id);

-- hotels: зв'язок з tours
CREATE INDEX idx_hotels_tour_id ON hotels (tour_id);

-- meals: зв'язок з tours
CREATE INDEX idx_meals_tour_id ON meals (tour_id);

-- passport: зв'язок з clients + пошук за номером
CREATE INDEX idx_passport_client_id ON passport (client_id);
CREATE INDEX idx_passport_number ON passport (passport_number);

-- payments: зв'язки з bookings і employees
CREATE INDEX idx_payments_booking_id ON payments (booking_id);
CREATE INDEX idx_payments_employee_id ON payments (employee_id);

-- transport: зв’язки з employee і tour
CREATE INDEX idx_transport_employee_id ON transport (employee_id);
CREATE INDEX idx_transport_tour_id ON transport (tour_id);

-- clients: пошук за прізвищем або email
CREATE INDEX idx_clients_last_name ON clients (last_name);
CREATE INDEX idx_clients_email ON clients (email);

-- employees: пошук за прізвищем або email
CREATE INDEX idx_employees_last_name ON employees (last_name);
CREATE INDEX idx_employees_email ON employees (email);

