Create table video(
idVideo int primary key,
titulo varchar(100),
repro int,
url varchar(100)
)


Create procedure sp_video_insertar
@idVideo int, @titulo varchar(100),@repro int,@url varchar(100)
as
begin
    insert into video values (@idVideo,@titulo,@repro,@url)
end

EXEC sp_video_insertar 1,'Video',1,'x'

