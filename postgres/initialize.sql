CREATE schema test_aspdotnetcore_mvc;
ALTER DATABASE test_aspdotnetcore_mvc SET timezone TO 'Asia/Tokyo';
ALTER database test_aspdotnetcore_mvc SET search_path TO test_aspdotnetcore_mvc;
create table test_aspdotnetcore_mvc."Content" (
  "Id" serial
  , "Name" varchar(256)
  , "Comment" text
  , "CreateAt" timestamp(6)
  , primary key ("Id")
);
