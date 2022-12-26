namespace FicheUEApiGestion;

public static class PdfExtensions
{
        static string RedColor = "#FF0000";
        static float TextPadding = 5;
        static IContainer Block(IContainer container)
        {
            return container
                .Border(1)
                .Background(Colors.Grey.Lighten3)
                .ShowOnce()
                .Padding(1)
                .Height(40, Unit.Point);
        }
        static IContainer SupportTableBlock(IContainer container)
        {
            return container
                .Border(1)
                .Background(Colors.White)
                .ShowOnce()
                .Padding(1)
                .Height(40, Unit.Point);
        }

        static IContainer Ligne10Block(IContainer container)
        {
            return container
                 .Border(1)
                .Background(Colors.White)
                .ShowOnce()
                .Padding(1)
                .Height(250, Unit.Point);
        }

        static IContainer Ligne18Block(IContainer container)
        {
            return container
                 .Border(1)
                .Background(Colors.White)
                .ShowOnce()
                .Padding(1)
                .Height(350, Unit.Point);
        }

        static IContainer Ligne6Block(IContainer container)
        {
            return container
                .Border(1)
                .Background(Colors.Grey.Lighten3)
                .ShowOnce()
                .Padding(1)
                .Height(60, Unit.Point);
        }



        static IContainer WhiteBlock(IContainer container)
        {
            return container
                .Border(1)
                .Background(Colors.White)
                .ShowOnce()
                .Padding(1)
                .Height(30, Unit.Point);
        }

        static IContainer Ligne7Block(IContainer container)
        {
            return container
                .Border(1)
                .Background(Colors.White)
                .ShowOnce()
                .Padding(1)
                .Height(100, Unit.Point);
        }

        static IContainer Ligne14Block(IContainer container)
        {
            return container
                .Border(1)
                .Background(Colors.White)
                .ShowOnce()
                .Padding(1)
                .Height(180, Unit.Point);
        }

        static IContainer Ligne8Block(IContainer container)
        {
            return container
                .Border(1)
                .Background(Colors.White)
                .ShowOnce()
                .Padding(1)
                .Height(150, Unit.Point);
        }


        static IContainer Ligne4WhiteBlock(IContainer container)
        {
            return container
                .Border(1)
                .Background(Colors.White)
                .ShowOnce()
                .Padding(1)
                .Height(170, Unit.Point);
        }


        static IContainer Ligne5WhiteBlock(IContainer container)
        {
            return container
                .Border(1)
                .Background(Colors.White)
                .ShowOnce()
                .Padding(1)
                .Height(120, Unit.Point);
        }


        static IContainer SecondWhiteBlock(IContainer container)
        {
            return container
                .Border(1)
                .Background(Colors.White)
                .ShowOnce()
                .Padding(1)
                .Height(45, Unit.Point);
        }

        static IContainer NiveauBlock(IContainer container)
        {
            return container
                .Border(2)
                .Background(Colors.White)
                .ShowOnce()
                .AlignCenter()
                .Padding(1)
                .Width(50, Unit.Point)
                .Height(5, Unit.Point);
        }


        public static IContainer AddFicheHeader(this IContainer container)
        {
            byte[] imageData = File.ReadAllBytes("Files/logo.png");

            container.Row(row =>
            {
                row.Spacing(1);

                row.ConstantItem(100)
                    .PaddingLeft(10)
                    .Image(imageData);

                row.RelativeItem()
                    .Column(col =>
                    {
                        col.Item().Text(text =>
                        {
                            text.DefaultTextStyle(font =>
                            {
                                font.FontSize(15);
                                return font;
                            });
                            text.AlignCenter();
                            text.Line("Haute Ecole Libre de Bruxelles - IIya Prigogine \nDESCRITPION DES UNITES D'ENSEIGNEMENT");
                        });
                    });
            });
            return container;
        }

        public static IContainer AddFicheOtherInformation(this IContainer container)
        {
            container.Row(row =>
            {
                row.Spacing(1);

                row.RelativeItem()
                    .Column(col =>
                    {
                        col.Item().Padding(30).Text(text =>
                        {
                            text.Line("");
                            text.Line("* Définitions :");
                            text.Line("* Article 15 . - § 1er du Décret \"paysage\" du 7 novembre 2013: ");
                            text.Span("Acquis d'apprentissage ").Underline();
                            text.Span(":  énoncé de ce que l'étudiant doit savoir, comprendre et être capable de réaliser au terme \r\nd'un processus d'apprentissage, d'un cursus ou d'une unité d'enseignement validée; les acquis d'apprentissage sont \r\ndéfinis en termes de savoirs, d'aptitudes et de compétences;\n");
                            text.Span("Compétence").Underline();
                            text.Span(": faculté évaluable pour un individu de mobiliser, combiner, transposer et mettre en œuvre des \r\nressources individuelles ou collectives dans un contexte particulier et à un moment donné; par ressources, il faut \r\nentendre notamment les connaissances, savoir-faire, expériences, aptitudes, savoir-être et attitudes;\r\n");
                            text.Span("Capacité ").Underline();
                            text.Span(":  « activité intellectuelle stabilisée et reproductible dans des champs divers de la connaissance. » \r\nMeirieu Ph., Apprendre, oui, mais comment ?, ESF éditeur, 1988, p. 153-154 . Cette proposition suggère que la \r\ncompétence serait une combinaison appropriée de plusieurs capacités dans une situation déterminée. ");
                            text.Hyperlink("http://commonweb.unifr.ch/artsdean/pub/gestens/f/as/files/3650/34116_091116.pdf",
                                "http://commonweb.unifr.ch/artsdean/pub/gestens/f/as/files/3650/34116_091116.pdf").FontColor("#0000ff");
                            text.Span(",la compétence étant un \r\n« savoir identifié mettant en jeu une ou des capacités, dans un champ notionnel ou disciplinaire déterminé. » \r\nMeirieu Ph., Apprendre, oui, mais comment ?, ESF éditeur, 1988, p. 153-154\r\n");
                            text.Span("**Un support obligatoire doit être mis en ligne, excepté s'il s'agit d'un livre protégé par le droit d'auteur (les \r\narticles par contre doivent être mis en ligne)");

                        });
                    });
            });

            return container;
        }

        public static IContainer AddUEHeader(this IContainer container)
        {
            container.Column(col =>
            {
                col.Item().Text(text =>
                {
                    text.AlignCenter();
                    text.DefaultTextStyle(style => style.Underline(true));
                    text.Line("MATHEMATIQUES APPLIQUEES II \nUE2-6");
                });

                col.Item().Text(text =>
                {
                    text.AlignCenter();
                    text.Line("Sous toute réserve des décisions du CNS (Conseil National de Sécurité) et des autorités de tutelle en fonction de l'évolution sanitaire")
                    .FontColor(RedColor)
                    .FontSize(10);
                });
            });


            return container;
        }

        public static TableDescriptor AddDepartement(this TableDescriptor container, string departement)
        {
            container.Cell().Row(1).Column(1).Element(Block).PaddingLeft(TextPadding).Text(text =>
            {
                text.AlignLeft();
                text.Line($"Département : {departement}").Bold();
            });
            return container;
        }

        public static TableDescriptor AddLigne1(this TableDescriptor container, string departement)
            => container.AddDepartement(departement);

        public static TableDescriptor AddLigne2(this TableDescriptor container, string cursus, string orientation)
        {
            container.Cell().Row(2).Column(1).Table(newTable =>
            {
                newTable.ColumnsDefinition(col =>
                {
                    col.RelativeColumn();
                    col.RelativeColumn();
                });
                newTable.Cell().Row(1).Column(1).Element(WhiteBlock).PaddingLeft(TextPadding).Text(text =>
                {
                    text.AlignLeft();
                    text.Span("Cursus : ");
                    text.Span($" {cursus}").Bold();
                });
                newTable.Cell().Row(1).Column(2).Element(WhiteBlock).PaddingLeft(TextPadding).Text(text =>
                {
                    text.AlignLeft();
                    text.Span("Orientation : ");
                    text.Span($" {orientation}").Bold();
                });
            });
            return container;
        }

        public static TableDescriptor AddLigne3(this TableDescriptor container, string implantation, string telephone)
        {
            container.Cell().Row(3).Column(1).Element(SecondWhiteBlock).PaddingLeft(TextPadding).Text(text =>
            {
                text.Span("Orientation : ");
                text.Span($" {implantation}").Bold();
                text.Line("");
                text.Span("Téléphone secrétariat : ");
                text.Span($" {telephone}");
            });
            return container;
        }

        public static TableDescriptor AddLigne4(this TableDescriptor container, string departement, bool obli = true)
        {
            container.Cell().Row(4).Column(1).Table(newTable =>
            {
                newTable.ColumnsDefinition(col =>
                {
                    col.RelativeColumn();
                    col.RelativeColumn();
                });
                newTable.Cell().Row(1).Column(1).Element(Ligne4WhiteBlock).PaddingLeft(TextPadding).Text(text =>
                {
                    text.AlignLeft();
                    text.EmptyLine();
                    text.Span("Cycle : ");
                    text.Span($" {departement}").Bold();
                    text.EmptyLine();
                    text.Span("Bloc d'études :");
                    text.Span($" {departement}").Bold();
                    text.EmptyLine();
                    text.Span("Situation dans la formation : ");
                    text.Span($"{departement}");
                    text.EmptyLine();
                    text.Line("Niveau du cadre européen des certifications :");
                    text.Span($"""
                                                     {departement}                               {departement}
                   """);

                });
                newTable.Cell().Row(1).Column(2).Element(Ligne4WhiteBlock).PaddingLeft(TextPadding).Text(text =>
                {
                    text.AlignLeft();
                    text.Span("Unité(s) d’enseignement pré-requise(s) : ");
                    text.Span($" {departement}").Bold();
                    text.EmptyLine();
                    text.EmptyLine();
                    text.Span("Unité(s) d’enseignement co-requise(s) :");
                    text.Span($" {departement}").Bold();
                    text.EmptyLine();
                    text.EmptyLine();
                    text.Span("Volume horaire (en présentiel) :");
                    text.Span($"{departement}").Bold();
                    text.EmptyLine();
                    text.Span("Nombre de credits ETCS (= pondération de l’U.E.)");
                    text.Span($"{departement}").Bold();
                    text.EmptyLine();
                    if (obli)
                    {
                        text.Span($"Obligatoire");
                        text.Span($" ou");
                        text.Span($" optionnelle").Strikethrough();
                    }
                    else
                    {
                        text.Span($"Obligatoire").Strikethrough();
                        text.Span($" ou");
                        text.Span($" optionnelle");
                    }
                    text.EmptyLine();
                    text.Span("Langue d’enseignement :");
                    text.Span(departement).Bold();
                    text.EmptyLine();
                    text.Span("Langue d’évaluation :");
                    text.Span(departement).Bold();

                });
            });
            return container;
        }

        public static TableDescriptor AddLigne5(this TableDescriptor container, string departement)
        {
            container.Cell().Row(5).Column(1).Table(newTable =>
            {
                newTable.ColumnsDefinition(col =>
                {
                    col.RelativeColumn();
                    col.RelativeColumn();
                });
                newTable.Cell().Row(1).Column(1).Element(Ligne5WhiteBlock).PaddingLeft(TextPadding).Text(text =>
                {
                    text.AlignLeft();
                    text.Span("Responsable de l’UE ").Underline();
                    text.Line(":");
                    text.Line(departement).Bold();
                });
                newTable.Cell().Row(1).Column(2).Element(Ligne5WhiteBlock).PaddingLeft(TextPadding).Text(text =>
                {
                    text.AlignLeft();
                    text.Span("Titulaire(s) des Activités d’Apprentissage").Underline();
                    text.Line(":");
                    text.Line(departement).Bold();
                    text.Line($"({departement})");
                    text.Line(departement).Bold();
                    text.Line($"({departement})");
                });
            });
            return container;
        }


        public static TableDescriptor AddLigne6(this TableDescriptor container, string departement)
        {
            container.Cell().Row(6).Column(1).Element(Ligne6Block).PaddingLeft(TextPadding).Text(text =>
            {
                text.AlignCenter();
                text.Span($"CONTRIBUTION AU PROFIL D’ENSEIGNEMENT").Underline().Bold();
                text.Line(":");
                text.Line("En regard de l’ensemble du programme de formation, l’UE contribue au développement des compétences et capacités suivantes :");
            });
            return container;
        }


        public static TableDescriptor AddLigne7(this TableDescriptor container, string departement)
        {
            container.Cell().Row(7).Column(1).Element(Ligne7Block).PaddingLeft(TextPadding).Column(column =>
            {
                column.Item().Text("Compétences* :");
                foreach (var i in Enumerable.Range(1, 4))
                {
                    column.Item().Row(row =>
                    {
                        row.Spacing(5);
                        row.AutoItem().Text($"C{i}."); // text or image
                        row.RelativeItem().Text(Placeholders.Sentence());
                    });
                }
            });
            return container;
        }


        public static TableDescriptor AddLigne8(this TableDescriptor container, string departement)
        {
            container.Cell().Row(8).Column(1).Element(Ligne8Block).PaddingLeft(TextPadding).Column(column =>
            {
                column.Item().Text("Capacités * :");
                foreach (var i in Enumerable.Range(1, 3))
                {
                    column.Item().PaddingLeft(TextPadding).Row(ro => ro.AutoItem().Text($"C{i}"));

                    foreach (var u in Enumerable.Range(1, 3))
                    {

                        column.Item().PaddingLeft(TextPadding * 2).Row(row =>
                        {
                            row.Spacing(5);
                            row.AutoItem().Text($"{u}."); // text or image
                            row.RelativeItem().Text(Placeholders.Sentence());
                        });
                    }
                }
            });
            return container;
        }


        public static TableDescriptor AddLigne9(this TableDescriptor container, string departement)
        {
            container.Cell().Row(9).Column(1).Element(Block).PaddingLeft(TextPadding).Text(text =>
            {
                text.AlignCenter();
                text.Line("ACQUIS D’APPRENTISSAGE* SPÉCIFIQUES").Underline().Bold();
            });
            return container;
        }


        public static TableDescriptor AddLigne10(this TableDescriptor container, string departement)
        {
            container.Cell().Row(10).Column(1).Element(Ligne10Block).PaddingLeft(TextPadding).Text(text =>
            {
                text.Line($"{departement} : : ").Bold();
                text.Line("Au terme de cette activité d’apprentissage, l’étudiant sera capable de faire apparaître la structure algorithmique de tout problème de la sphère relevant des mathématiques. Nous privilégierons la méthode de résolution, la réflexion avant l’action en utilisant par exemple la technique du jeu de test pour circonscrire le problème à résoudre et le comprendre.");
                text.Line($"{departement} : : ").Bold();
                text.Line("Au terme de cette activité d’apprentissage, l’étudiant sera capable de faire apparaître la structure algorithmique de tout problème de la sphère relevant des mathématiques. Nous privilégierons la méthode de résolution, la réflexion avant l’action en utilisant par exemple la technique du jeu de test pour circonscrire le problème à résoudre et le comprendre.");
            });
            return container;
        }


        public static TableDescriptor AddLigne11(this TableDescriptor container, string departement)
        {
            container.Cell().Row(11).Column(1).Element(Block).PaddingLeft(TextPadding).Text(text =>
            {
                text.AlignCenter();
                text.Line("CONTENU SYNTHÉTIQUE").Underline().Bold();
            });
            return container;
        }


        public static TableDescriptor AddLigne12(this TableDescriptor container, string departement)
        {
            container.Cell().Row(12).Column(1).Element(Ligne10Block).PaddingLeft(TextPadding).Column(column =>
            {
                foreach (var i in Enumerable.Range(1, 3))
                {
                    column.Item().PaddingLeft(TextPadding).Row(ro => ro.AutoItem().Text($"{departement}").Bold());
                    foreach (var u in Enumerable.Range(1, 3))
                    {

                        column.Item().PaddingLeft(TextPadding * 2).Row(row =>
                        {
                            row.Spacing(5);
                            row.AutoItem().Text($"{u}."); // text or image
                            row.RelativeItem().Text(Placeholders.Sentence());
                        });
                    }
                }
            });
            return container;
        }


        public static TableDescriptor AddLigne13(this TableDescriptor container, string departement)
        {
            container.Cell().Row(13).Column(1).Element(Block).PaddingLeft(TextPadding).Text(text =>
            {
                text.AlignCenter();
                text.Line("MÉTHODES D’APPRENTISSAGE").Underline().Bold();
            });
            return container;
        }


        public static TableDescriptor AddLigne14(this TableDescriptor container, string departement)
        {
            container.Cell().Row(14).Column(1).Element(Ligne14Block).PaddingLeft(TextPadding).Column(column =>
            {
                foreach (var u in Enumerable.Range(1, 2))
                {
                    column.Item().Text($"Compétences {u} :");
                    foreach (var i in Enumerable.Range(1, 3))
                    {
                        column.Item().PaddingLeft(TextPadding * 2).Row(row =>
                        {
                            row.Spacing(5);
                            row.AutoItem().Text($"{i}."); // text or image
                            row.RelativeItem().Text(Placeholders.Sentence());
                        });
                    }
                }
            });
            //container.Cell().Row(14).Column(1).Element(Ligne14Block).Column(column =>
            //{
            //    column.Item().Text("Compétences* :");
            //    foreach (var i in Enumerable.Range(1, 4))
            //    {
            //        column.Item().Row(row =>
            //        {
            //            row.Spacing(5);
            //            row.AutoItem().Text($"C{i}."); // text or image
            //            row.RelativeItem().Text(Placeholders.Sentence());
            //        });
            //    }
            //});
            return container;
        }


        public static TableDescriptor AddLigne15(this TableDescriptor container, string departement)
        {
            container.Cell().Row(15).Column(1).Element(Block).PaddingLeft(TextPadding).Text(text =>
            {
                text.AlignCenter();
                text.Line("SUPPORTS DE COURS").Underline().Bold();
            });
            return container;
        }


        public static TableDescriptor AddLigne16(this TableDescriptor container, string departement)
        {
            container.Cell().Row(16).Column(1).Table(newTable =>
            {
                newTable.ColumnsDefinition(col =>
                {
                    col.ConstantColumn(450);
                    col.RelativeColumn();
                    col.RelativeColumn();
                });
                newTable.Cell().Row(1).Column(1).Element(SupportTableBlock).PaddingLeft(TextPadding).Text(text =>
                {
                    text.AlignCenter();
                    text.Line($"Support sur e-Campus");
                });
                newTable.Cell().Row(1).Column(2).Element(SupportTableBlock).PaddingLeft(TextPadding).Text(text =>
                {
                    text.AlignCenter();
                    text.Line($"Obligatoire");
                });
                newTable.Cell().Row(1).Column(3).Element(SupportTableBlock).PaddingLeft(TextPadding).Text(text =>
                {
                    text.AlignCenter();
                    text.Line($"En ligne**");
                });

                foreach (var i in Enumerable.Range(2, 2))
                {
                    newTable.Cell().Row((uint)i).Column(1).Element(SupportTableBlock).PaddingLeft(TextPadding).Text(text =>
                    {
                        text.Line($"Cours {i} ");
                    });
                    newTable.Cell().Row((uint)i).Column(2).Element(SupportTableBlock).PaddingLeft(TextPadding).Text(text =>
                    {
                        text.AlignCenter();
                        text.Line($"Obligatoire {i} ");
                    });
                    newTable.Cell().Row((uint)i).Column(3).Element(SupportTableBlock).PaddingLeft(TextPadding).Text(text =>
                    {
                        text.AlignCenter();
                        text.Line($"En ligne** {i} ");
                    });
                }
            });
            return container;
        }


        public static TableDescriptor AddLigne17(this TableDescriptor container, string departement)
        {
            container.Cell().Row(17).Column(1).Element(Block).PaddingLeft(TextPadding).Text(text =>
            {
                text.AlignCenter();
                text.Line("MODALITÉS D’ÉVALUATION").Underline().Bold();
            });
            return container;
        }

        public static TableDescriptor AddLigne18(this TableDescriptor container, string departement)
        {
            container.Cell().Row(18).Column(1).Element(Ligne18Block).PaddingLeft(TextPadding).Text(text =>
            {
                text.Span("Orientation : ");
                text.Span($" {departement}").Bold();
                text.Line("");
                text.Span("Téléphone secrétariat : ");
                text.Span($" {departement}");
            });
            return container;
        }


        public static TableDescriptor AddCursus(this TableDescriptor container, string departement)
        {
            return container;
        }

        public static TableDescriptor AddOrientation(this TableDescriptor container, string departement)
        {
            return container;
        }
        public static TableDescriptor AddImplantation(this TableDescriptor container, string departement)
        {
            return container;
        }
        public static TableDescriptor AddTelephone(this TableDescriptor container, string departement)
        {
            return container;
        }
        public static TableDescriptor AddCycle(this TableDescriptor container, string departement)
        {
            return container;
        }
        public static TableDescriptor AddBlocEtude(this TableDescriptor container, string departement)
        {
            return container;
        }
        public static TableDescriptor AddSituation(this TableDescriptor container, string departement)
        {
            return container;
        }
        public static TableDescriptor AddNiveau(this TableDescriptor container, string departement)
        {
            return container;
        }

        public static TableDescriptor AddVolumeHoraire(this TableDescriptor container, string departement)
        {
            return container;
        }


        public static TableDescriptor AddNbrCredit(this TableDescriptor container, string departement)
        {
            return container;
        }

        public static TableDescriptor AddRequierement(this TableDescriptor container, string departement)
        {
            return container;
        }

        public static TableDescriptor AddLangueEnseignement(this TableDescriptor container, string departement)
        {
            return container;
        }

        public static TableDescriptor AddLangueEvaluation(this TableDescriptor container, string departement)
        {
            return container;
        }

        public static TableDescriptor AddResponsableUE(this TableDescriptor container, string responsable)
        {
            return container;
        }

        public static TableDescriptor AddTitulaireCours(this TableDescriptor container, string prof, string cours)
        {
            return container;
        }

        public static TableDescriptor AddContribution(this TableDescriptor container)
        {
            return container;
        }


        public static TableDescriptor AddCompetences(this TableDescriptor container, List<string> Competences)
        {
            return container;
        }

        public static TableDescriptor AddCapacties(this TableDescriptor container, string departement)
        {
            return container;
        }


        public static TableDescriptor AddAcquisition(this TableDescriptor container, string departement)
        {
            return container;
        }

        public static TableDescriptor AddContenuSynthetique(this TableDescriptor container, string departement)
        {
            return container;
        }

        public static TableDescriptor AddMethodeApprentissage(this TableDescriptor container, string departement)
        {
            return container;
        }

        public static TableDescriptor AddSupportsCours(this TableDescriptor container, string departement)
        {
            return container;
        }

        public static TableDescriptor AddModaliteEvaluation(this TableDescriptor container, string departement)
        {
            return container;
        }
    

}
