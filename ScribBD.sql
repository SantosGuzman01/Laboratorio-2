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

Create procedure sp_video_editar2
@titulo varchar(100), @repro int,@url varchar(100),@idVideo int 
as
begin
    update video set titulo =  @titulo, repro = @repro, url = @url where idVideo = @idVideo
end

Create procedure sp_video_borrar
@idVideo int
as
begin
    Delete from video where idVideo = @idVideo
end

Create procedure sp_video_verVideo2
as
begin
    Select * from video
end

select * from video