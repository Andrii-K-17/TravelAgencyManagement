# Database Setup

## 1. Run Oracle XE container
```bash
docker run -d --name oracle-tour-agency -p 1521:1521 -e ORACLE_PASSWORD=TrMgmt_Pass gvenzl/oracle-xe
```

#### Wait for initialization
```bash
docker logs -f oracle-tour-agency
```

## 2. Create schema user
#### Login as administrator:
```bash
docker exec -it oracle-tour-agency sqlplus system/TrMgmt_Pass@XEPDB1
```

#### Execute SQL to create user:
```bash
-- Create User
CREATE USER TOUR_MANAGEMENT IDENTIFIED BY TrMgmt_Pass;
ALTER USER TOUR_MANAGEMENT QUOTA UNLIMITED ON USERS;

-- Grant Permissions
GRANT CONNECT, RESOURCE TO TOUR_MANAGEMENT;
GRANT CREATE SESSION, CREATE TABLE, CREATE VIEW, CREATE SEQUENCE, CREATE PROCEDURE TO TOUR_MANAGEMENT;
exit;
```

## 3. Initialize schema & data
#### Connect as the new user to the PDB:
```bash
docker exec -i oracle-tour-agency sqlplus TOUR_MANAGEMENT/TrMgmt_Pass@XEPDB1
```

#### Inside SQL*Plus, run scripts:
1. Create schema
```bash
@schema.sql
```
2. Create indexes
```bash
@indexes.sql
```
3. Load sample data
```bash
@sample-data.sql
```
