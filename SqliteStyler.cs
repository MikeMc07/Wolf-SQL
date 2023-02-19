using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScintillaNET;
using EasyScintilla.Stylers;
using System.Drawing;

namespace WolfSQL
{
    public class SqllisteStyler : ScintillaStyler
    {
        public SqllisteStyler()
            : base(Lexer.Sql, lineNumbers: true, codeFolding: true, braceMatching: true, autoIndent: true)
        {
        }

        public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
        {
            // Set the Styles
            scintilla.Styles[Style.LineNumber].ForeColor = Color.FromArgb(255, 128, 128, 128); //Dark Gray
            scintilla.Styles[Style.LineNumber].BackColor = Color.FromArgb(255, 228, 228, 228); //Light Gray
            scintilla.Styles[Style.Sql.Comment].ForeColor = Color.Green;
            scintilla.Styles[Style.Sql.CommentLine].ForeColor = Color.Green;
            scintilla.Styles[Style.Sql.CommentLineDoc].ForeColor = Color.Green;
            scintilla.Styles[Style.Sql.Number].ForeColor = Color.Maroon;
            scintilla.Styles[Style.Sql.Word].ForeColor = Color.Blue;
            scintilla.Styles[Style.Sql.Word2].ForeColor = Color.MidnightBlue; // Color.Fuchsia;
            scintilla.Styles[Style.Sql.Word2].Bold = true;
            scintilla.Styles[Style.Sql.User1].ForeColor = Color.Gray;
            scintilla.Styles[Style.Sql.User2].ForeColor = Color.FromArgb(255, 00, 128, 192); //Medium Blue-Green
            scintilla.Styles[Style.Sql.String].ForeColor = Color.Red;
            scintilla.Styles[Style.Sql.Character].ForeColor = Color.Red;
            scintilla.Styles[Style.Sql.Operator].ForeColor = Color.Black;
            scintilla.Styles[Style.Sql.Operator].Bold = true;
            //scintilla.Styles[Style.Sql.Identifier].Bold = true;
            //scintilla.Styles[Style.Sql.Identifier].ForeColor = Color.Red;

        }

        public override void RemoveStyle(ScintillaNET.Scintilla scintilla)
        {
        }

        public override void SetKeywords(ScintillaNET.Scintilla scintilla)
        {
            // Set keyword lists
            // Word = 0
            string types = "int integer tinyint smallint mediumint bigint unsigned big int int2 int8 character varchar varying character " +
                            "nchar native character nvarchar text clob blob real double double precision float numeric decimal boolean " +
                            "date datetime ";

            string str = "group_concat julianday ntile nullif sqlite_compileoption_get current_timestamp "+
                         "sqlite_compileoption_used sum quote printf likelihood last_value rank round rtrim " +
                         "nth_value random trim time total substr replace upper typeof load_extension avg abs " +
                         "strftime randomblob unicode percent_rank row_number last_insert_rowid sqlite_log " +
                         "unlikely char count date total_changes changes sqlite_version coalesce glob zeroblob " +
                         "hex sqlite_source_id datetime cume_dist instr dense_rank ifnull current_date current_time " +
                         "lag like max min lead lower ltrim first_value length likely optimize bm25 match matchinfo " +
                         "fts5_decode highlight fts5_decode_none offsets fts5_source_id fts5_rowid fts5_expr " +
                         "fts5_isalnum fts3_tokenizer fts5 fts5_expr_tcl fts5_fold snippet";

            string keywords = "abort action add after all alter always analyze and as asc attach before begin between " +
                            "by cascade case cast check collate column commit conflict constraint create cross current current_date " +
                            "current_time current_timestamp database default deferrable deferred delete desc detach distinct do drop " +
                            "each else end escape except exclude exclusive exists explain fail filter first following for " +
                            "from full generated glob group groups having if ignore immediate in indexed initially inner insert " +
                            "instead intersect into is isnull join last left limit match materialized natural no nothing " +
                            "of or order others outer over partition plan preceding query " +
                            "raise range recursive regexp reindex release rename replace restrict returning right rollback " +
                            "row rows savepoint select set table temp temporary then ties to transaction trigger unbounded union " +
                            "update using vacuum values view virtual when where window with without ";

            scintilla.SetKeywords(0, keywords);
            // Word2 = 1
            scintilla.SetKeywords(1, types);
            // User1 = 4
            scintilla.SetKeywords(4, str);
            // User2 = 5
            scintilla.SetKeywords(5, "sys objects sysobjects pragma like unique primary not null notnull nulls offset autoincrement foreign index key on references ");
        }
    }
}
