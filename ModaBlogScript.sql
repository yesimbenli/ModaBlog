USE [ModaBlogDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Etikets]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etikets](
	[EtiketID] [int] IDENTITY(1,1) NOT NULL,
	[EtiketAdi] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Etikets] PRIMARY KEY CLUSTERED 
(
	[EtiketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kategoris]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoris](
	[KategoriID] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Kategoris] PRIMARY KEY CLUSTERED 
(
	[KategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kisis]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisis](
	[KisiID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](max) NOT NULL,
	[Telefon] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Kisis] PRIMARY KEY CLUSTERED 
(
	[KisiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Makales]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Makales](
	[MakaleID] [int] IDENTITY(1,1) NOT NULL,
	[Baslik] [nvarchar](max) NULL,
	[Icerik] [nvarchar](max) NULL,
	[Yazar] [nvarchar](max) NULL,
	[ResimURL] [nvarchar](max) NULL,
	[Tarih] [datetime] NOT NULL,
	[KategoriID] [int] NOT NULL,
	[UyeID] [int] NOT NULL,
	[Okuma] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Makales] PRIMARY KEY CLUSTERED 
(
	[MakaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Uyes]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uyes](
	[UyeID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Sifre] [nvarchar](max) NULL,
	[AdSoyad] [nvarchar](max) NULL,
	[Fotograf] [nvarchar](max) NULL,
	[YetkiID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Uyes] PRIMARY KEY CLUSTERED 
(
	[UyeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yetkis]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetkis](
	[YetkiID] [int] IDENTITY(1,1) NOT NULL,
	[Yetkisi] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Yetkis] PRIMARY KEY CLUSTERED 
(
	[YetkiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yorums]    Script Date: 17.01.2018 18:42:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yorums](
	[YorumID] [int] IDENTITY(1,1) NOT NULL,
	[Icerik] [nvarchar](max) NULL,
	[UyeID] [int] NOT NULL,
	[MakaleID] [int] NOT NULL,
	[Tarih] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Yorums] PRIMARY KEY CLUSTERED 
(
	[YorumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201801171154193_AutomaticMigration', N'DAL.Migrations.Configuration', 0x1F8B0800000000000400DD5DDB6EE4B8117D0F907F10FA2909BC6E5F328389D1DE85C71E27C6FA06B7BDC83E0D6889DD16AC4BAF44CDBA13EC97E5219F945F08299192289212A96B7BB1C0C2CDCB29AAAA4816ABC89AFFFDE7BF8B1FDE7CCFFA06A3D80D83D3D9E1FEC1CC82811D3A6EB03E9D2568F5DDA7D90FDFFFF10F8B2F8EFF66FDC4DA1D9376B867109FCE5E10DA9CCCE7B1FD027D10EFFBAE1D8571B842FB76E8CF8113CE8F0E0EFE363F3C9C430C31C35896B5784802E4FA30FD817F9E87810D372801DE4DE8402FA6E5B86699A25AB7C087F106D8F0747671763DB3CE3C1760D24BE8AD661608821001840776F214C3258AC260BDDCE002E03D6E3710B75B012F8674C0274573DDB11F1C91B1CF8B8E0CCA4E6214FA868087C79419F36AF7562C9DE5CCC2ECFA82D98AB6E4AB53969DCEBE20F715A29955257572EE45A4196E9176D9CF18BF9FB5DFB3B2D2BD5CE25831C87F7BD679E2A12482A7014C5004BC3DEB3E79F65CFB47B87D0C5F61701A249E571E121E14AEE30A70D17D146E6084B60F70C50DF4EA6266CDF9DEF36AF7BCB3D033FBA0AB001D1FCDAC5B3C10F0ECC15CFAA58F5FA230827F87018C0082CE3D4008465878570E4C3F5B188394E299E3329258E7F07C995937E0ED1A066BF4723AC37FCEAC4BF70D3AAC840EE32970F1F4C29D5094409ED2625EC8AF56AA3FE261AFC3C8D5972BEB31816419E936B22DF71D4BBA8CE694F2756313D9E2D653C815936D2553DA6F2C799E39CB700B9C1E64290CB29EF023F4E08AACEABD2A916439F281EB4DA5AA37E01578505F59B3F613A86B46B88DC2163DC752D9CF20F6DCD7C115E7CA86D108647E06FF02D1E0541E60ECFA4F0FD783137A0491FBC2A85C60F93E624BD67871D0DFD9EA719EB61A9A590F71F79AF8C004427B7160FAFE10D62F1137B9817B166F6E21DA671DF733C8CB08C3FD1A46AFFB65C43D4BBB5FB1CE1CE9AE33C787CFABE34F1F3E02E7F8E35FE1F187366BCE9563BEDA5CD5ED5487479F86D8A9C8FF6BA81E7DF8D80BD55BF0CD5DA7A2AF2A718CA533B31EA097D6C62FEE263BDC71F2FE4A9B5D46A14F7EF3FA95D57E5D864964938F09954DF0045E93335127952650FDAB3543DD7DD5262315D55BDA947C509B99C0488C3D1BD87887A5DB4AE3FAD7B6DDD7B4F7B2883699E1BAABA80695F33058B9910FF3AFFC1C629D0581F198EF411C63D13AFF00F1CBE086D312DA4984156A8980BF199CDAFD4B18C0DBC47F86C3DB9E255ABD89E6F1D7F012D8F81CF12520BD3AE35D87F66B98A02F81436CD627648B26AC26402FC339B36D18C7975899A1731E2601EA6806E3A56C6A2BE6DC03AE5F6FC690617E65ED443BA654AD3464CA6D64964CDD08AFC3B51B688C90B5538C30ABAE1F216D633A4282A43140DA4C31BEB4B67E785993DE2CC1541EFD6FCE29ECEF7D871EDE9D329521998A8F101D7C034A29FD04BCA46F52AD66433AF7FB9F0D29ECEECF867498B8F89BEB10D343E380C41A6378ADF6F2B357F39CAB8C6CECE9C07DE6D8C4C75903B4A7CBD3D6C0678E1B4FE030A79E45E353BB8E43B2C7681D81C6121A205C374EA445724E7257D1F05B467F61B17A3A97210AD711580D1F6680E8D5D09DAE3D5D536CFD099B369F60CAE62C309DB49ABCEB6FDAA604E3C902EC3F8751526BAF57E4499A4F214F42B7953C59C7B1E4395228B18768976E34B7FF20A04A3BCFE238B4DD540C92B8198D7AF0A3F91238567308249345358C82C582D5D5DD6005C525D8F0995515F12EB8801E44D03AB3B35B6DE720B6812332057F9063303076DC960CAC08A7F083FB8B4013CF0E18914E80B841633CDFDC008953C90D6C7703BC462E557A6A9E6FC9B7E734AA351770030342B091133AC4E5D11332809C4E45284D1C5ACC4B1AA7A78865BF5593C0A54E2CB9C447564599EB4C3132EAD0195419258C1A511B25CCD0A1AE8CFB8DAE8ED449A925F4AAC77277D4B1E227558C8C7A548657479E5163AB23CF8CF7A58E994B5A4BE615FFF4EE2823EF159F6E9B16B934B626729CD83145CCAC48DC07E11E3062766D5A02DF6497FDF1E0E8C926A67676551D08E21222EE82BB4794B03059A92AB01705F37A0876BF4D0E525C606F82C1874405447A7C6CE89E19FB72007673B50182869A84EEBC49DD00529D3F7580C51C6B00A5D7A16A818C46C60293B588D432328065D1C45A58BAC3357DF25621CCD49FDAD039F539C8BB53FF4E130039557B400A9039142A00A5092CB2A67CA5ADD4507DF1ADBAB2681D02F36FC8355958A1B4CE6C251C893257371CFEC30D98C205C8D55C519E47B44F24A5EFA132D0E08BEC00A1600CFB867E39C3A652036764A6B1B671DC9E33155B56C119F60DFD72862A62036324469AAE99D69E2DBC55D5D34462CEA4DC0CC8EB16F3ECD1242D58CC15AF2B173760B3718375E9B5252DB196D953CBF3EF96E64F12FD0C636E737CAE1A2D39251446600D2BB598341EE9A51BC5E80220F00C882BEDDCF1856685D1A358B9199DAA5D238A8E2DE8AC07F93BEB757176CDAC1ED112A4CD2FF157F8C4964CFDA82519AB3A5AE46D2BC09B89F235E379E8257E50FF3AB219290D8B895069B188B59857BE47B066054609470D9EF35A72291B8BA692C94D4973D9A8BBAA785A7EB55166AAFA8DA30E9A2023AE6277A4446D716309114BBD8574A4DD94BCA4AF0A39364A5F28D6A1E441D1324C5EA88F933FFD2BE3E4850673380B3873F3372BDA19AD288E58A67A410F60E69AA1EAA8E26211F2293352F520B00E893DCC2BE3B0327D14162C2BA3B0327D14FAACAE0C428BF4318A47736598A2D440E3B38018A7EF5991F97AD8CFEA4A63856520E995963A0CFA34AE8C418B7666FEA94CDAFAB9C7792FCC67607D77A5DE57165699BF4CDD3BBBDE5DEE9F95EC8C244473BEAD547217507BC9A82194F3857A30B909A3F06AAA5158B8925B4F1421CCC924A5F2A7E84BA7A364C69A3326F6432D46E9598B0056AAD347E55F1E9531F91A7DC4CAF3A23264A5CA6094E54744DC20CB15ADF0141C95B730D887856743DC962CD4EA234B1E1095A125D52DB02563AED61958F3E21B23CEAE17AB0DAC8BFCC15175BDDCE15D49E931D55FF832F77FB7D54F8131CC12D8CFB6567ACA51062A151B62D1C71A02182DDF49F551BA95F5D5270BF374531F05867A6DE15E3DF04B4BED530D3526F794815BBEEB9E72A8F1CC94742AAB69DBEA984F4273E60297F61AF2A8C73F24E08E9F5CCDB8C6177D0BC0193359D1F84EADE2267F19A82835705DB0EBE69CF3427E793D459946E1F380B1A9CA67E16473A557F4EB8B8DB538B12BC111AF584C290E167E3716471A9C6F210E793F251BD9A57B8E8DF22BFC7538FDB807FB5813FB739C9AB80707552F216E5A6D9253A725F9EF3C6E4A6396CDA96A852066D66466312B012FE6DB18417F9F34D85FFEE29D7B2E24E710D6E006EF3B2B18A3EC19C9ECE8E0F0A892FC767712D1CEE3D8E15EB928B3D1F2D21A393DAC4BF8DBF8DAC534F74B35236CF00D44F60B88FEE483B73F97E1FAC8FADA827FFD26611D848792BCAB837051082B8E99EE7410CE559E722AB9D6266BA9810824D3A2FC5E760861CA228163A7031D44A47C06D04E42E09FE67582E232797642AA66EBEC04C63DC673B000503F193953C976C9C7D90680CBC6D90CD02E17678B09D32DC90B93AF9872A143AACA0254B8F17E1538F0ED74F6EFB4D7497A2B8FFC9516EF5957F153E0FE92E08A47AC5ED66F629EA8FE53F7299245E603FDED5D6461D467F9D53FBF665DF7ACBB089BB227D64185D16DC4CFE766341A4DD6B5C368DA656C7CBF534DBA7BD74D95F6F90B9F5DF3855296BBB0D33622CD4FD809519283B02FBC5E58A8CA31D8064B995F50B621EB7CAC3CDF609BA129730DB6DAE02B9906F5D720D673C24D4812791B63491AC444DEAD8D49C8F5D669A28BF9DC86383DE9E46CEB669FBCB35C68BD6D9DF762AAB3DEB0A7D47BA3FC666DECD91E728E0DE39C92A4199BC43522315BCAE9C23A21E9FA91DAA4FDEAE677E0D353F5782A9644DCC64DB53588B656B26B0DB177486263E3E6B41A84713DFACA3A3B82A47EC62E69AA343D6383A7A9DA95CC548557A6F615FEE009A9C64E6EA14DF35DA69EDAA5842A3457427D2685C133A98CAD5FAA2BA206EECB5D4E26B54B0A464F6DF539357E770AA6BA44BACB0AA69F1E6A97F46BEAED710AEDD2DE1E274FF9242649A8CA945E83E2AFDFA8733A65F793B0A5F81C62A96716625627A6A6A88217299D04F8A24A4680D56A9048CF34227C5A2C85C635CDB02C119400CC2A64D0595D33386FDF0A24F86A19A1EC1F3990A70751112B66A79260D1444D549D97A48E706346AA7A8266C4A80D554B91B6A927ABC8D753479B6EAFB5B4699B7ADA8A8C3855DA698E2B815A5A2AC3C715CD9834F195804ACB65B89973A11939CB88252267E552645225224F91454B9AA7479695AD61EB94A028F3BBED60D62CE50768B3819BA08A97603D3362882459DD19C1AD168A374D3D33A2FF9C58DDD9D0E7B430C88125DED9C6D65812107758F6EB02C6EEBA805860CC00DA9C1D96B7B90A562133072B23624DAABE3C8880838DB4B308B92B60235C4D42D26992FC34CC470202CFD0B90AEE12B44910FE64E83F7B5C088C989575F4D3445FFC9817779BF45F51EBE313F0305DE241BC0B3E27AEE7E4E3BE9478101510C45EA5CE5A224B449CB6EB6D8E741B069A40947DB999FD08FD8D87C1E2BB6009BEC13663C3EA770DD7C0DE1631411548B32078B62F2E5CB08E801F538CA23FFE8975D8F1DFBEFF3F33CE94138B870000, N'6.2.0-61023')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ed0e1342-2a1d-45ad-906a-3b8eeb23c6db', N'Admin')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0f34560d-8ec5-4830-9d5b-0e123514b9ae', N'admin@erp2.com', 0, N'ABpnGARsFoR5Oh/tpzFOIp36rEHMdUJLEKjcHrZna1Gy4qK79ydUXyvtzU0VUMHMUg==', N'dfe397d1-fac5-4258-bd76-e666683308e6', NULL, 0, 0, NULL, 0, 0, N'admin@erp2.com')
SET IDENTITY_INSERT [dbo].[Makales] ON 

INSERT [dbo].[Makales] ([MakaleID], [Baslik], [Icerik], [Yazar], [ResimURL], [Tarih], [KategoriID], [UyeID], [Okuma]) VALUES (4, N'Banyo Tuzu Yapımı', N'<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:11pt"><span style="background-color:#f7f7f7"><span style="font-family:Calibri,sans-serif"><span style="font-size:13.5pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Banyo tuzunu kullanım y&ouml;nteminiz &ccedil;ok &ccedil;eşitli olabilir. Banyonuza yerleştirip dekor olarak kullanabilir ya da pakete sarıp sevdiklerinize hediye edebilirsiniz. Dilerseniz bacaklarınıza peeling olarak da kullanabilirsiniz. En g&uuml;zel kullanım y&ouml;ntemi ise duşa girince duş kabinine ya da k&uuml;vete yarım avu&ccedil; banyo tuzunu d&ouml;k&uuml;p, suyu a&ccedil;manız. Karışımın, kokunun uzun bir g&uuml;n&uuml;n ardından sizi rahatlatmasına izin verin. Anın tadını &ccedil;ıkarın. Kendi g&uuml;n&uuml;n&uuml;z&uuml; g&uuml;zelleştirin!</span></span></span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:11pt"><span style="background-color:#f7f7f7"><span style="font-family:Calibri,sans-serif"><span style="font-size:13.5pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Nane esansı ferahlatıcı etkisi &uuml;zerine kas ağrılarını dindirerek v&uuml;cutta rahatlatıcı bir etki yaratır. Okaliptus esansı ise tazelik verir, canlandırıcı bir kokuya sahiptir. Hamilelik ve emzirme d&ouml;neminde esans kullanımı i&ccedil;in mutlaka doktorunuza danışınız. Astım hastaları i&ccedil;in okaliptus esansı &ouml;nerilmemektedir. Gıda boyasını karışıma renk vermesi i&ccedil;in kullanılmaktadır. Dilerseniz kullanmayabilirsiniz. Karışımı 3 ay i&ccedil;inde t&uuml;ketmeyi unutmayın!</span></span></span></span></span></span></p>

<p>&nbsp;</p>

<p><span style="font-size:19.5pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333"><img alt="" src="http://www.bilgisaglik.com/wp-content/uploads/2014/05/banyo-tuzu.gif" style="height:123px; width:200px" /></span></span></span></p>

<p><span style="font-size:19.5pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">&nbsp;Malzemeler:</span></span></span></p>

<p><span style="font-size:13.0pt"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">&bull; 60 gr deniz tuzu&nbsp;<br />
&bull; 30 gr karbonat&nbsp;<br />
&bull; Okaliptus esansı 6-8 damla<br />
&bull; Nane esansı 10-12 damla<br />
&bull; Mavi gıda boyası 1 damla<br />
&bull; Boş kap<br />
&bull; Kase</span></span></span><br />
&nbsp;</p>
', NULL, NULL, CAST(N'2018-01-17T17:50:56.393' AS DateTime), 0, 0, 0)
INSERT [dbo].[Makales] ([MakaleID], [Baslik], [Icerik], [Yazar], [ResimURL], [Tarih], [KategoriID], [UyeID], [Okuma]) VALUES (5, N'Kurutulmuş Portakallar', N'<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Kış meyvelerini ayrı bir seviyoruz. Son g&uuml;nlerde hem i&ccedil;mek hem de yemek i&ccedil;in kullandığımız portakalları başka nerede kullansak diye d&uuml;ş&uuml;n&uuml;nce portakal kurutmaya karar verdik.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Ara &ouml;ğ&uuml;n olarak yemek, &ccedil;aylarınızı tatlandırmak, hediyelerimizi s&uuml;slemek, yılbaşı ağa&ccedil;larınıza takmak, masadaki kaselerde s&uuml;s olarak kullanmak ve daha bir s&uuml;r&uuml; yaratacı proje i&ccedil;in kurutulmuş portakalları kullanabilirsiniz.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Evde her zaman bulunan yoksa da sadece bir malzeme ile siz de portakalları kurutup g&uuml;n&uuml;n&uuml;z&uuml; g&uuml;zelleştirmek i&ccedil;in adım atın.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333"><img alt="" src="http://cerezkapimda.com/content/images/thumbs/0001248_quru-kurutulmus-portakal-kup-30gr.jpeg" style="height:200px; width:200px" /></span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><strong><span style="color:#333333">Malzemeler</span></strong></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">-2 adet portakal</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">-Bı&ccedil;ak</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">-Fırın Kağıdı</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">-Pe&ccedil;ete</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">-Fırın</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><strong><span style="color:#333333">Yapılışı</span></strong></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">100 derecede fırını ısıtmaya başlayın.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Portakalları orta boyutta dilim dilim kesin.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Pe&ccedil;ete ile portakalın suyunu alın.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Fırın kağıdını tepsiye koyup pe&ccedil;ete ile kuruttuğunuz portakalları&nbsp; dizin.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Tepsiyi fırına yerleştirin.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Yaklaşık 3 saat boyunca 100 derecede pişirin.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Yarım saat aralıklar ile portakalları &ccedil;evirin.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Fırından &ccedil;ıktıktan sonra 1 saat dinlendirin.</span></span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="background-color:#f7f7f7"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Yemek ve i&ccedil;ecekler i&ccedil;in kullanacaksanız kavanozda saklamanızı &ouml;neririz.</span></span></span></span></p>
', NULL, NULL, CAST(N'2018-01-17T17:55:56.510' AS DateTime), 0, 0, 0)
INSERT [dbo].[Makales] ([MakaleID], [Baslik], [Icerik], [Yazar], [ResimURL], [Tarih], [KategoriID], [UyeID], [Okuma]) VALUES (7, N'Kendi Dudak Peelinginizi Yapın', N'<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">Bu haftanın en &ccedil;ok kullanılan c&uuml;mlesi &ldquo;Havalar &ccedil;ok soğudu&rdquo; oldu. Hal b&ouml;yle olunca d&uuml;şen dereceler ve soğuklar ilk dudaklarımızı vurdu.</span></span></span></p>

<p><span style="font-size:16px"><span style="font-family:&quot;Calibri&quot;,sans-serif"><span style="color:#333333">P&uuml;t&uuml;r p&uuml;t&uuml;r kurumaya başlamış dudaklarınız i&ccedil;in bu hafta lezzetli ve yararlı bir tarif verelim istedik. 10 dakikada hazırlayacağınız iki kişilik bu dudak nemlendiricisi ile dudaklarınızı beslemeye başlayın.</span></span></span></p>

<p><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,serif"><strong><span style="color:#333333"><img alt="" src="http://www.kadinsitesidir.com/wp-content/uploads/2017/02/lipbalmdogal.png" style="height:162px; width:200px" /></span></strong></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,serif"><strong><span style="color:#333333">Malzemeler</span></strong></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">-2 adet yuvarlak boş metal kap (Eski şeker kabı kullandım)<br />
-3 tatlı kaşığı balmumu<br />
-3 tatlı kaşığı hindistancevizi yağı<br />
-1 tatlı kaşığı kakao (nutella ya da eritilmiş &ccedil;ikolata da olur)</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,serif"><strong><span style="color:#333333">Yapılışı</span></strong></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">1. Balmumu ve hindistancevizi yağını ısıya dayanıklı cam bir kaba koyun.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">2. Benmari y&ouml;ntemi ile kısık ateşte ikisini de eritin. (Dilerseniz mikrodalgada 2 dakikalık aralıklarla kontrol ederek de eritebilirsiniz)</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">3. Karışımı bir kaseye d&ouml;k&uuml;p iyice karıştırın. Daha sonra &uuml;zerine kakao ya da &ccedil;ikolatayı ekleyerek iyice karıştırmaya devam edin.</span></span></span></p>

<p style="margin-left:0cm; margin-right:0cm"><span style="font-size:16px"><span style="font-family:&quot;Times New Roman&quot;,serif"><span style="color:#333333">4. &Ccedil;ok bekletmeden karışımı kaplara d&ouml;k&uuml;n.</span></span></span></p>

<p><span style="font-size:13.5pt"><span style="font-family:&quot;Calibri&quot;,sans-serif"><span style="color:#333333"><span style="font-size:16px">5. Birini kendiniz kullanın birini sevdiğiniz birine hediye edin. Yapmanın, paylaşmanın ve yumuşacık &ccedil;ikolata aromalı dudakların keyfini &ccedil;ıkarın</span></span></span></span></p>
', NULL, NULL, CAST(N'2018-01-17T18:04:24.310' AS DateTime), 0, 0, 0)
SET IDENTITY_INSERT [dbo].[Makales] OFF
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
