-- Tạo cơ sở dữ liệu
CREATE DATABASE QLSTUDIO;
USE QLSTUDIO;

-- Bảng DanceType: Quản lý các loại nhảy
CREATE TABLE DanceType (
    dance_type_id INT PRIMARY KEY IDENTITY(1,1),
    dance_type_name NVARCHAR(255) NOT NULL
);

-- Bảng Teacher: Quản lý thông tin giáo viên
CREATE TABLE Teacher (
    teacher_id INT PRIMARY KEY IDENTITY(1,1),
    teacher_name NVARCHAR(255) NOT NULL,
    phone NVARCHAR(15) NOT NULL,
    email NVARCHAR(255),
    dance_type_id INT NOT NULL,
    FOREIGN KEY (dance_type_id) REFERENCES DanceType(dance_type_id)
);

-- Bảng DanceRoom: Quản lý phòng tập
CREATE TABLE DanceRoom (
    room_id INT PRIMARY KEY IDENTITY(1,1),
    room_name NVARCHAR(255) NOT NULL,
    dance_type_id INT NOT NULL,
    teacher_id INT NOT NULL,
    room_capacity INT NOT NULL,
    FOREIGN KEY (dance_type_id) REFERENCES DanceType(dance_type_id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(teacher_id)
);

-- Bảng Member: Quản lý học viên
CREATE TABLE Member (
    member_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    phone NVARCHAR(15) NOT NULL,
    email NVARCHAR(255),
    gender NVARCHAR(10) CHECK(gender IN ('Nam', 'Nữ')) NOT NULL,
    dob DATE
);

-- Bảng Schedule: Quản lý lịch học
CREATE TABLE Schedule (
    schedule_id INT PRIMARY KEY IDENTITY(1,1),
    room_id INT NOT NULL,
    time_slot NVARCHAR(50) NOT NULL,
    date DATE NOT NULL,
    teacher_id INT NOT NULL,
    FOREIGN KEY (room_id) REFERENCES DanceRoom(room_id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(teacher_id)
);

-- Bảng Registration: Quản lý đăng ký học
CREATE TABLE Registration (
    registration_id INT PRIMARY KEY IDENTITY(1,1),
    member_id INT NOT NULL,
    schedule_id INT NOT NULL,
    date_registered DATE NOT NULL,
    FOREIGN KEY (member_id) REFERENCES Member(member_id),
    FOREIGN KEY (schedule_id) REFERENCES Schedule(schedule_id)
);

-- Bảng Attendance: Quản lý điểm danh
CREATE TABLE Attendance (
    attendance_id INT PRIMARY KEY IDENTITY(1,1),
    schedule_id INT NOT NULL,
    member_id INT NOT NULL,
    attendance_date DATE NOT NULL,
    status NVARCHAR(20) CHECK(status IN ('Có mặt', 'Vắng mặt')) NOT NULL,
    FOREIGN KEY (schedule_id) REFERENCES Schedule(schedule_id),
    FOREIGN KEY (member_id) REFERENCES Member(member_id)
);

-- Insert dữ liệu mẫu
-- Bảng DanceType
INSERT INTO DanceType (dance_type_name) VALUES 
('Hip Hop'),
('Sext Dance'),
('Cali Dance'),
('Pop Dance'),
('Breakdance'),
('Popping'),
('Flashmob'),
('Shuffle Dance'),
('Hiphop Choreography'),
('Dance Fitness'),
('Dance Workout'),
('Cardio Dance'),
('Belly Dance'),
('Warking');

-- Bảng Teacher
INSERT INTO Teacher (teacher_name, phone, email, dance_type_id) VALUES 
('Nguyễn Văn A', '0901234567', 'vana@example.com', 1),
('Trần Thị B', '0902234567', 'tranb@example.com', 2),
('Lê Văn C', '0903234567', 'levanc@example.com', 3),
('Phạm Thị D', '0904234567', 'phamd@example.com', 4),
('Hoàng Văn E', '0905234567', 'hoange@example.com', 5);

-- Bảng DanceRoom
INSERT INTO DanceRoom (room_name, dance_type_id, teacher_id, room_capacity) VALUES 
('Phòng A', 1, 1, 20),
('Phòng B', 2, 2, 15),
('Phòng C', 3, 3, 25),
('Phòng D', 4, 4, 30),
('Phòng E', 5, 5, 20);

-- Bảng Member
INSERT INTO Member (name, phone, email, gender, dob) VALUES 
('Nguyễn Văn T', '0987654321', 'vant@example.com', 'Nam', '2000-01-01'),
('Trần Thị M', '0987654322', 'tranm@example.com', 'Nữ', '1995-05-05'),
('Lê Văn K', '0987654323', 'levank@example.com', 'Nam', '1998-08-08'),
('Phạm Thị H', '0987654324', 'phamh@example.com', 'Nữ', '1993-03-03'),
('Hoàng Thị P', '0987654325', 'hoangp@example.com', 'Nữ', '2001-12-12');

-- Bảng Schedule
INSERT INTO Schedule (room_id, time_slot, date, teacher_id) VALUES 
(1, '18:00-19:00', '2025-01-10', 1),
(2, '19:00-20:00', '2025-01-11', 2),
(3, '20:00-21:00', '2025-01-12', 3),
(4, '17:00-18:00', '2025-01-13', 4),
(5, '18:30-19:30', '2025-01-14', 5);

-- Bảng Registration
INSERT INTO Registration (member_id, schedule_id, date_registered) VALUES 
(1, 1, '2025-01-01'),
(2, 2, '2025-01-02'),
(3, 3, '2025-01-03'),
(4, 4, '2025-01-04'),
(5, 5, '2025-01-05');

-- Bảng Attendance
INSERT INTO Attendance (schedule_id, member_id, attendance_date, status) VALUES 
(1, 1, '2025-01-10', 'Có mặt'),
(2, 2, '2025-01-11', 'Vắng mặt'),
(3, 3, '2025-01-12', 'Có mặt'),
(4, 4, '2025-01-13', 'Có mặt'),
(5, 5, '2025-01-14', 'Có mặt');

-- Tạo lại bảng Admin với kiểu dữ liệu hợp lý cho username
CREATE TABLE Admin (
    admin_id INT PRIMARY KEY IDENTITY,   -- Đảm bảo admin_id là khóa chính
    username NVARCHAR(100) NOT NULL UNIQUE,  -- Đặt độ dài giới hạn hợp lý cho username
    password NVARCHAR(255) NOT NULL,     -- Đảm bảo password có độ dài đủ để lưu mật khẩu mã hóa
    role NVARCHAR(50) NOT NULL DEFAULT 'admin'
);

-- Chèn dữ liệu admin mẫu
INSERT INTO Admin (username, password, role) VALUES 
('admin123', 'admin123987', 'admin');
