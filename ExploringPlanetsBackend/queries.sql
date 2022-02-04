select * from AspNetRoles;

select * from AspNetUsers;

select * from AspNetUserRoles;

select * from Planets;

delete from AspNetUsers;

select * from Crews;

delete from AspNetUsers
where Id = '1643982852074';

insert into AspNetUsers
values ('default', 'default', 'default', 'default', 'default', 0, 'default', 'default', 'default', null, 0, 0, null, 1, 0, 'default', 'default');

delete from Planets;

insert into AspNetRoles
values ('Captain', 'Captain', 'Captain', null);

insert into Planets
values ('TAU23', 'TAU 23', 'No description yet', 'En route', 'default', 'without image');

insert into Planets
values ('ZETTA7', 'ZETTA 7', 'No description yet', 'En route', 'default', 'without image');

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