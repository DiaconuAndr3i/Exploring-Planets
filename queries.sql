select * from AspNetRoles;

select * from AspNetUsers;

select * from AspNetUserRoles;

select * from Planets;

delete from AspNetUsers;

select * from Crews;

delete from AspNetUsers;

delete from AspNetUsers
where Id = '1644253877105';

insert into AspNetUsers
values ('default', 'default', 'default', 'default', 'default', 0, 'default', 'default', 'default', null, 0, 0, null, 1, 0, 'default', 'default');

delete from Planets;

delete from Planets
where Id = 'TAU23';

insert into AspNetRoles
values ('Captain', 'Captain', 'Captain', null);

insert into Planets
values ('TAU23', 'TAU 23', 'No description yet', 'En route', 'default', 'planet1.jpg');

insert into Planets
values ('ZETTA7', 'ZETTA 7', 'No description yet', 'En route', 'default', 'planet2.jpg');

insert into Planets
values ('SIGMA17', 'SIGMA 17', 'No description yet', 'En route', 'default', 'planet3.jpg');

insert into Planets
values ('KAPPA44', 'KAPPA 44', 'No description yet', 'En route', 'default', 'planet4.jpg');

insert into Planets
values ('DELTA13', 'DELTA 13', 'No description yet', 'En route', 'default', 'planet5.jpg');

select * from Robots;

insert into Robots
values ('A1', 'A1');

insert into Robots
values ('A2', 'A2');

insert into Robots
values ('A3', 'A3');

insert into Robots
values ('B1', 'B1');

insert into Robots
values ('B2', 'B2');

insert into Robots
values ('B3', 'B3');

insert into Robots
values ('C1', 'C1');

insert into Robots
values ('C2', 'C2');

insert into Robots
values ('C3', 'C3');

insert into Robots
values ('D1', 'D1');

insert into Robots
values ('D2', 'D2');

insert into Robots
values ('D3', 'D3');