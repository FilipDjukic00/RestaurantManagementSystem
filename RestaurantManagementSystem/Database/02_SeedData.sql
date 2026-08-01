USE RestaurantManagementDB;
GO

-- =============================================
-- USERS
-- =============================================

INSERT INTO Users
(
    Username,
    Password,
    FullName,
    Role,
    IsActive
)
VALUES
('admin','admin123','Restaurant Administrator',0,1),
('marko','waiter123','Marko Markovic',1,1),
('ana','customer123','Ana Petrovic',2,1);

-- =============================================
-- FOODS
-- =============================================

INSERT INTO Foods
(
    Name,
    Price,
    Description,
    IsAvailable
)
VALUES
('Burger',650,'Juicy beef burger with cheddar cheese',1),

('Pizza Capricciosa',800,'Classic pizza with ham and mushrooms',1),

('Chicken Caesar Salad',550,'Fresh salad with grilled chicken',1),

('Beef Steak',1400,'Premium aged beef steak',1);

-- =============================================
-- SIDE DISHES
-- =============================================

INSERT INTO SideDishes
(
    Name,
    Price,
    IsAvailable
)
VALUES
('French Fries',180,1),

('Onion Rings',220,1),

('Grilled Vegetables',250,1),

('Rice',150,1);

-- =============================================
-- FOOD - SIDE DISH
-- =============================================

INSERT INTO FoodSideDishes
VALUES
(1,1),

(1,2),

(4,1),

(4,3);
GO