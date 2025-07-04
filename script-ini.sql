--
-- PostgreSQL database dump
--

-- Dumped from database version 10.11
-- Dumped by pg_dump version 10.11

-- Started on 2025-07-04 01:43:29

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 197 (class 1259 OID 93822)
-- Name: DeliveryNote; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."DeliveryNote" (
    "Id" uuid NOT NULL,
    "Description" text NOT NULL,
    "DeliveryDate" timestamp with time zone NOT NULL,
    "State" text NOT NULL,
    "ImagePath" text NOT NULL,
    "PacientId" uuid NOT NULL
);


ALTER TABLE public."DeliveryNote" OWNER TO postgres;

--
-- TOC entry 198 (class 1259 OID 93830)
-- Name: DeliveryRoute; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."DeliveryRoute" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL,
    "LatitudeOrigin" double precision NOT NULL,
    "LongitudeOrigin" double precision NOT NULL,
    "LatitudeDestination" double precision NOT NULL,
    "LongitudeDestination" double precision NOT NULL
);


ALTER TABLE public."DeliveryRoute" OWNER TO postgres;

--
-- TOC entry 199 (class 1259 OID 93838)
-- Name: ExitNote; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."ExitNote" (
    "Id" uuid NOT NULL,
    "Number" integer NOT NULL,
    "Description" text NOT NULL,
    "ExitDate" timestamp with time zone NOT NULL,
    "DeliveryPersonId" uuid NOT NULL
);


ALTER TABLE public."ExitNote" OWNER TO postgres;

--
-- TOC entry 200 (class 1259 OID 93846)
-- Name: ExitNoteDetail; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."ExitNoteDetail" (
    "Id" uuid NOT NULL,
    "Quantity" integer NOT NULL,
    "PackageId" uuid NOT NULL,
    "ExitNoteId" uuid NOT NULL
);


ALTER TABLE public."ExitNoteDetail" OWNER TO postgres;

--
-- TOC entry 196 (class 1259 OID 93817)
-- Name: __EFMigrationsHistory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);


ALTER TABLE public."__EFMigrationsHistory" OWNER TO postgres;

--
-- TOC entry 2819 (class 0 OID 93822)
-- Dependencies: 197
-- Data for Name: DeliveryNote; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2820 (class 0 OID 93830)
-- Dependencies: 198
-- Data for Name: DeliveryRoute; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2821 (class 0 OID 93838)
-- Dependencies: 199
-- Data for Name: ExitNote; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2822 (class 0 OID 93846)
-- Dependencies: 200
-- Data for Name: ExitNoteDetail; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 2818 (class 0 OID 93817)
-- Dependencies: 196
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."__EFMigrationsHistory" VALUES ('20250704054007_InitialCreate', '9.0.5');


--
-- TOC entry 2690 (class 2606 OID 93829)
-- Name: DeliveryNote PK_DeliveryNote; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."DeliveryNote"
    ADD CONSTRAINT "PK_DeliveryNote" PRIMARY KEY ("Id");


--
-- TOC entry 2692 (class 2606 OID 93837)
-- Name: DeliveryRoute PK_DeliveryRoute; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."DeliveryRoute"
    ADD CONSTRAINT "PK_DeliveryRoute" PRIMARY KEY ("Id");


--
-- TOC entry 2694 (class 2606 OID 93845)
-- Name: ExitNote PK_ExitNote; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ExitNote"
    ADD CONSTRAINT "PK_ExitNote" PRIMARY KEY ("Id");


--
-- TOC entry 2696 (class 2606 OID 93850)
-- Name: ExitNoteDetail PK_ExitNoteDetail; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ExitNoteDetail"
    ADD CONSTRAINT "PK_ExitNoteDetail" PRIMARY KEY ("Id");


--
-- TOC entry 2688 (class 2606 OID 93821)
-- Name: __EFMigrationsHistory PK___EFMigrationsHistory; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");


--
-- TOC entry 2829 (class 0 OID 0)
-- Dependencies: 6
-- Name: SCHEMA public; Type: ACL; Schema: -; Owner: postgres
--

GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2025-07-04 01:43:32

--
-- PostgreSQL database dump complete
--

