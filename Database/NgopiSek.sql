PGDMP  8                 
    |            NgopiSek    16.3    16.3 <    *           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            +           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ,           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            -           1262    25087    NgopiSek    DATABASE     �   CREATE DATABASE "NgopiSek" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Indonesian_Indonesia.1252';
    DROP DATABASE "NgopiSek";
                postgres    false            �            1259    25141    detail_transaksi    TABLE     �   CREATE TABLE public.detail_transaksi (
    id_detail_transaksi integer NOT NULL,
    id_transaksi integer NOT NULL,
    id_produk integer NOT NULL,
    kuantitas integer NOT NULL
);
 $   DROP TABLE public.detail_transaksi;
       public         heap    postgres    false            �            1259    25140 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_transaksi_id_detail_transaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ?   DROP SEQUENCE public.detail_transaksi_id_detail_transaksi_seq;
       public          postgres    false    226            .           0    0 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE OWNED BY     u   ALTER SEQUENCE public.detail_transaksi_id_detail_transaksi_seq OWNED BY public.detail_transaksi.id_detail_transaksi;
          public          postgres    false    225            �            1259    25096    pengguna    TABLE       CREATE TABLE public.pengguna (
    id_pengguna integer NOT NULL,
    nama_pengguna character varying(50) NOT NULL,
    username_pengguna character varying(100) NOT NULL,
    password_pengguna character varying(150) NOT NULL,
    id_role integer NOT NULL
);
    DROP TABLE public.pengguna;
       public         heap    postgres    false            �            1259    25095    kasir_id_kasir_seq    SEQUENCE     �   CREATE SEQUENCE public.kasir_id_kasir_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.kasir_id_kasir_seq;
       public          postgres    false    216            /           0    0    kasir_id_kasir_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.kasir_id_kasir_seq OWNED BY public.pengguna.id_pengguna;
          public          postgres    false    215            �            1259    25103    kategori    TABLE     u   CREATE TABLE public.kategori (
    id_kategori integer NOT NULL,
    nama_kategori character varying(50) NOT NULL
);
    DROP TABLE public.kategori;
       public         heap    postgres    false            �            1259    25102    kategori_id_kategori_seq    SEQUENCE     �   CREATE SEQUENCE public.kategori_id_kategori_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.kategori_id_kategori_seq;
       public          postgres    false    218            0           0    0    kategori_id_kategori_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.kategori_id_kategori_seq OWNED BY public.kategori.id_kategori;
          public          postgres    false    217            �            1259    25122    metode_pembayaran    TABLE     �   CREATE TABLE public.metode_pembayaran (
    id_metode_pembayaran integer NOT NULL,
    nama_metode_pembayaran character varying(50) NOT NULL
);
 %   DROP TABLE public.metode_pembayaran;
       public         heap    postgres    false            �            1259    25121 *   metode_pembayaran_id_metode_pembayaran_seq    SEQUENCE     �   CREATE SEQUENCE public.metode_pembayaran_id_metode_pembayaran_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 A   DROP SEQUENCE public.metode_pembayaran_id_metode_pembayaran_seq;
       public          postgres    false    222            1           0    0 *   metode_pembayaran_id_metode_pembayaran_seq    SEQUENCE OWNED BY     y   ALTER SEQUENCE public.metode_pembayaran_id_metode_pembayaran_seq OWNED BY public.metode_pembayaran.id_metode_pembayaran;
          public          postgres    false    221            �            1259    25110    produk    TABLE     �   CREATE TABLE public.produk (
    id_produk integer NOT NULL,
    nama_produk character varying(100) NOT NULL,
    harga_produk integer NOT NULL,
    stok_produk integer NOT NULL,
    id_kategori integer NOT NULL
);
    DROP TABLE public.produk;
       public         heap    postgres    false            �            1259    25109    produk_id_produk_seq    SEQUENCE     �   CREATE SEQUENCE public.produk_id_produk_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.produk_id_produk_seq;
       public          postgres    false    220            2           0    0    produk_id_produk_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.produk_id_produk_seq OWNED BY public.produk.id_produk;
          public          postgres    false    219            �            1259    33440    role    TABLE     i   CREATE TABLE public.role (
    id_role integer NOT NULL,
    nama_role character varying(50) NOT NULL
);
    DROP TABLE public.role;
       public         heap    postgres    false            �            1259    33439    role_id_role_seq    SEQUENCE     �   CREATE SEQUENCE public.role_id_role_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.role_id_role_seq;
       public          postgres    false    228            3           0    0    role_id_role_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.role_id_role_seq OWNED BY public.role.id_role;
          public          postgres    false    227            �            1259    25129 	   transaksi    TABLE     �   CREATE TABLE public.transaksi (
    id_transaksi integer NOT NULL,
    tanggal_transaksi date NOT NULL,
    customer_name character varying(100) NOT NULL,
    id_metode_pembayaran integer NOT NULL,
    id_kasir integer NOT NULL
);
    DROP TABLE public.transaksi;
       public         heap    postgres    false            �            1259    25128    transaksi_id_transaksi_seq    SEQUENCE     �   CREATE SEQUENCE public.transaksi_id_transaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.transaksi_id_transaksi_seq;
       public          postgres    false    224            4           0    0    transaksi_id_transaksi_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.transaksi_id_transaksi_seq OWNED BY public.transaksi.id_transaksi;
          public          postgres    false    223            s           2604    25144 $   detail_transaksi id_detail_transaksi    DEFAULT     �   ALTER TABLE ONLY public.detail_transaksi ALTER COLUMN id_detail_transaksi SET DEFAULT nextval('public.detail_transaksi_id_detail_transaksi_seq'::regclass);
 S   ALTER TABLE public.detail_transaksi ALTER COLUMN id_detail_transaksi DROP DEFAULT;
       public          postgres    false    225    226    226            o           2604    25106    kategori id_kategori    DEFAULT     |   ALTER TABLE ONLY public.kategori ALTER COLUMN id_kategori SET DEFAULT nextval('public.kategori_id_kategori_seq'::regclass);
 C   ALTER TABLE public.kategori ALTER COLUMN id_kategori DROP DEFAULT;
       public          postgres    false    217    218    218            q           2604    25125 &   metode_pembayaran id_metode_pembayaran    DEFAULT     �   ALTER TABLE ONLY public.metode_pembayaran ALTER COLUMN id_metode_pembayaran SET DEFAULT nextval('public.metode_pembayaran_id_metode_pembayaran_seq'::regclass);
 U   ALTER TABLE public.metode_pembayaran ALTER COLUMN id_metode_pembayaran DROP DEFAULT;
       public          postgres    false    222    221    222            n           2604    25099    pengguna id_pengguna    DEFAULT     v   ALTER TABLE ONLY public.pengguna ALTER COLUMN id_pengguna SET DEFAULT nextval('public.kasir_id_kasir_seq'::regclass);
 C   ALTER TABLE public.pengguna ALTER COLUMN id_pengguna DROP DEFAULT;
       public          postgres    false    215    216    216            p           2604    25113    produk id_produk    DEFAULT     t   ALTER TABLE ONLY public.produk ALTER COLUMN id_produk SET DEFAULT nextval('public.produk_id_produk_seq'::regclass);
 ?   ALTER TABLE public.produk ALTER COLUMN id_produk DROP DEFAULT;
       public          postgres    false    219    220    220            t           2604    33443    role id_role    DEFAULT     l   ALTER TABLE ONLY public.role ALTER COLUMN id_role SET DEFAULT nextval('public.role_id_role_seq'::regclass);
 ;   ALTER TABLE public.role ALTER COLUMN id_role DROP DEFAULT;
       public          postgres    false    228    227    228            r           2604    25132    transaksi id_transaksi    DEFAULT     �   ALTER TABLE ONLY public.transaksi ALTER COLUMN id_transaksi SET DEFAULT nextval('public.transaksi_id_transaksi_seq'::regclass);
 E   ALTER TABLE public.transaksi ALTER COLUMN id_transaksi DROP DEFAULT;
       public          postgres    false    223    224    224            %          0    25141    detail_transaksi 
   TABLE DATA           c   COPY public.detail_transaksi (id_detail_transaksi, id_transaksi, id_produk, kuantitas) FROM stdin;
    public          postgres    false    226   �G                 0    25103    kategori 
   TABLE DATA           >   COPY public.kategori (id_kategori, nama_kategori) FROM stdin;
    public          postgres    false    218   1H       !          0    25122    metode_pembayaran 
   TABLE DATA           Y   COPY public.metode_pembayaran (id_metode_pembayaran, nama_metode_pembayaran) FROM stdin;
    public          postgres    false    222   pH                 0    25096    pengguna 
   TABLE DATA           m   COPY public.pengguna (id_pengguna, nama_pengguna, username_pengguna, password_pengguna, id_role) FROM stdin;
    public          postgres    false    216   �H                 0    25110    produk 
   TABLE DATA           `   COPY public.produk (id_produk, nama_produk, harga_produk, stok_produk, id_kategori) FROM stdin;
    public          postgres    false    220   I       '          0    33440    role 
   TABLE DATA           2   COPY public.role (id_role, nama_role) FROM stdin;
    public          postgres    false    228   �I       #          0    25129 	   transaksi 
   TABLE DATA           s   COPY public.transaksi (id_transaksi, tanggal_transaksi, customer_name, id_metode_pembayaran, id_kasir) FROM stdin;
    public          postgres    false    224   �I       5           0    0 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE SET     W   SELECT pg_catalog.setval('public.detail_transaksi_id_detail_transaksi_seq', 10, true);
          public          postgres    false    225            6           0    0    kasir_id_kasir_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.kasir_id_kasir_seq', 9, true);
          public          postgres    false    215            7           0    0    kategori_id_kategori_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.kategori_id_kategori_seq', 4, true);
          public          postgres    false    217            8           0    0 *   metode_pembayaran_id_metode_pembayaran_seq    SEQUENCE SET     X   SELECT pg_catalog.setval('public.metode_pembayaran_id_metode_pembayaran_seq', 2, true);
          public          postgres    false    221            9           0    0    produk_id_produk_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.produk_id_produk_seq', 10, true);
          public          postgres    false    219            :           0    0    role_id_role_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.role_id_role_seq', 2, true);
          public          postgres    false    227            ;           0    0    transaksi_id_transaksi_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.transaksi_id_transaksi_seq', 5, true);
          public          postgres    false    223            �           2606    25146 &   detail_transaksi detail_transaksi_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_pkey PRIMARY KEY (id_detail_transaksi);
 P   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_pkey;
       public            postgres    false    226            v           2606    25101    pengguna kasir_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT kasir_pkey PRIMARY KEY (id_pengguna);
 =   ALTER TABLE ONLY public.pengguna DROP CONSTRAINT kasir_pkey;
       public            postgres    false    216            x           2606    25108    kategori kategori_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT kategori_pkey PRIMARY KEY (id_kategori);
 @   ALTER TABLE ONLY public.kategori DROP CONSTRAINT kategori_pkey;
       public            postgres    false    218            |           2606    25127 (   metode_pembayaran metode_pembayaran_pkey 
   CONSTRAINT     x   ALTER TABLE ONLY public.metode_pembayaran
    ADD CONSTRAINT metode_pembayaran_pkey PRIMARY KEY (id_metode_pembayaran);
 R   ALTER TABLE ONLY public.metode_pembayaran DROP CONSTRAINT metode_pembayaran_pkey;
       public            postgres    false    222            z           2606    25115    produk produk_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.produk
    ADD CONSTRAINT produk_pkey PRIMARY KEY (id_produk);
 <   ALTER TABLE ONLY public.produk DROP CONSTRAINT produk_pkey;
       public            postgres    false    220            �           2606    33447    role role_nama_role_key 
   CONSTRAINT     W   ALTER TABLE ONLY public.role
    ADD CONSTRAINT role_nama_role_key UNIQUE (nama_role);
 A   ALTER TABLE ONLY public.role DROP CONSTRAINT role_nama_role_key;
       public            postgres    false    228            �           2606    33445    role role_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.role
    ADD CONSTRAINT role_pkey PRIMARY KEY (id_role);
 8   ALTER TABLE ONLY public.role DROP CONSTRAINT role_pkey;
       public            postgres    false    228            ~           2606    25134    transaksi transaksi_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_pkey PRIMARY KEY (id_transaksi);
 B   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_pkey;
       public            postgres    false    224            �           2606    25152 0   detail_transaksi detail_transaksi_id_produk_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_produk_fkey FOREIGN KEY (id_produk) REFERENCES public.produk(id_produk);
 Z   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_id_produk_fkey;
       public          postgres    false    220    4730    226            �           2606    25147 3   detail_transaksi detail_transaksi_id_transaksi_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_transaksi_fkey FOREIGN KEY (id_transaksi) REFERENCES public.transaksi(id_transaksi);
 ]   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_id_transaksi_fkey;
       public          postgres    false    4734    226    224            �           2606    33458    transaksi fk_id_kasir    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT fk_id_kasir FOREIGN KEY (id_kasir) REFERENCES public.pengguna(id_pengguna);
 ?   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT fk_id_kasir;
       public          postgres    false    4726    216    224            �           2606    33453    pengguna fk_role    FK CONSTRAINT     s   ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT fk_role FOREIGN KEY (id_role) REFERENCES public.role(id_role);
 :   ALTER TABLE ONLY public.pengguna DROP CONSTRAINT fk_role;
       public          postgres    false    216    4740    228            �           2606    25116    produk produk_id_kategori_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.produk
    ADD CONSTRAINT produk_id_kategori_fkey FOREIGN KEY (id_kategori) REFERENCES public.kategori(id_kategori);
 H   ALTER TABLE ONLY public.produk DROP CONSTRAINT produk_id_kategori_fkey;
       public          postgres    false    218    4728    220            �           2606    25135 -   transaksi transaksi_id_metode_pembayaran_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaksi
    ADD CONSTRAINT transaksi_id_metode_pembayaran_fkey FOREIGN KEY (id_metode_pembayaran) REFERENCES public.metode_pembayaran(id_metode_pembayaran);
 W   ALTER TABLE ONLY public.transaksi DROP CONSTRAINT transaksi_id_metode_pembayaran_fkey;
       public          postgres    false    4732    224    222            %   B   x��� !��v1;�^迎��cš�Pw��0��N���YO��ŝ*o��ա��������|
�         /   x�3�t�OKKM�2����S�r�9�����L8]R��S�J�b���� &�d      !      x�3�tN,��2������� ,�         \   x�3��M-.����鹉�9z������1��gP~^bNJ>g�FR�(4�L�K)J��H��|�C.΢�̌�<(�lX �*F��� 3�0�         �   x�E�M� F��)8��*.���J�n��@���'^_ ��,�|�f(\�f�#�|�@B018��7R�.���q�ض$�)��i��p	���)$����� 7��j�e��YD�n�����f�A����"��8C&�V���
��.:�ٻ�Z)o��6j�������̟;���<	      '      x�3�LL����2��N,�,����� @�U      #   Q   x�3�4202�54�50�t��LN�4�4�2Bq:�'q���Ɯ��E9��&	N�Ĳ��zS��)�kDm� X��     