using System;

namespace Telerik.WinControls.UI.Localization
{

    public class LocalizationPortuguesBrasil : RadGridLocalizationProvider
    {

        /// <summary>
        /// Com texto em ingl�s original, caso exista alguma d�vida
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue: return "Por favor, selecione um valor v�lido da c�lula";// "Please select valid cell value";
                case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue: return "Por favor, selecione um valor v�lido";// Please set a valid cell value";
                case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues: return "Por favor, coloque um valor v�lido";// Please set a valid cell values";
                case RadGridStringId.ConditionalFormattingPleaseSetValidExpression: return "Por favor, coloque uma express�o v�lida";// Please set a valid expression";
                case RadGridStringId.ConditionalFormattingItem: return "Item";

                case RadGridStringId.ConditionalFormattingInvalidParameters: return "Par�metros inv�lidos";// Invalid parameters";
                case RadGridStringId.FilterFunctionBetween: return "Entre";//Between";
                case RadGridStringId.FilterFunctionContains: return "Cont�m";//Contains";
                case RadGridStringId.FilterFunctionDoesNotContain: return "N�o contenha";// Does not contain";
                case RadGridStringId.FilterFunctionEndsWith: return "Termina com";// Ends with";
                case RadGridStringId.FilterFunctionEqualTo: return "Igual a";// Equals";
                case RadGridStringId.FilterFunctionGreaterThan: return "Maior que";// Greater than";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Maior que ou igual a";// Greater than or equal to";
                case RadGridStringId.FilterFunctionIsEmpty: return "� vazio";//Is empty";
                case RadGridStringId.FilterFunctionIsNull: return "� nulo";//Is null";
                case RadGridStringId.FilterFunctionLessThan: return "Menor que";//Less than";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Menor que ou igual a";//Less than or equal to";
                case RadGridStringId.FilterFunctionNoFilter: return "Sem filtro";//No filter";
                case RadGridStringId.FilterFunctionNotBetween: return "N�o est� entre";// Not between";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Diferente de";//Not equal to";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "N�o � vazio";//Is not empty";
                case RadGridStringId.FilterFunctionNotIsNull: return "N�o � nulo";//Is not null";
                case RadGridStringId.FilterFunctionStartsWith: return "Come�a com";//Starts with";
                case RadGridStringId.FilterFunctionCustom: return "Personalizado";//Custom";

                case RadGridStringId.FilterOperatorBetween: return "Entre";// "Between";
                case RadGridStringId.FilterOperatorContains: return "Cont�m";// "Contains";
                case RadGridStringId.FilterOperatorDoesNotContain: return "N�o cont�m";// "NotContains";
                case RadGridStringId.FilterOperatorEndsWith: return "TerminaCom"; // "EndsWith";
                case RadGridStringId.FilterOperatorEqualTo: return "Igual"; // "Equals";
                case RadGridStringId.FilterOperatorGreaterThan: return "Maior que";// "GreaterThan";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "Maior ou igual a";// "GreaterThanOrEquals";
                case RadGridStringId.FilterOperatorIsEmpty: return "� vazio"; // "IsEmpty";
                case RadGridStringId.FilterOperatorIsNull: return "� nulo";// "IsNull";
                case RadGridStringId.FilterOperatorLessThan: return "Menor que";// "LessThan";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "LessThanOrEquals";
                case RadGridStringId.FilterOperatorNoFilter: return "Sem filtro";// "No filter";
                case RadGridStringId.FilterOperatorNotBetween: return "N�oEntre"; // "NotBetween";
                case RadGridStringId.FilterOperatorNotEqualTo: return "Diferente"; // "NotEquals";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "Preenchido";// "NotEmpty";
                case RadGridStringId.FilterOperatorNotIsNull: return "N�o nulo"; // "NotNull";
                case RadGridStringId.FilterOperatorStartsWith: return "Come�a com";// "StartsWith";
                case RadGridStringId.FilterOperatorIsLike: return "parecido com"; //"Like";
                case RadGridStringId.FilterOperatorNotIsLike: return "diferente de";// "NotLike";
                case RadGridStringId.FilterOperatorIsContainedIn: return "Contido em";// "ContainedIn";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "N�o contido em"; // "NotContainedIn";
                case RadGridStringId.FilterOperatorCustom: return "Personalizado"; // "Custom";

                case RadGridStringId.CustomFilterMenuItem: return "Personalizado"; // "Custom";
                case RadGridStringId.CustomFilterDialogCaption: return "Filtro da grade [{0}]"; //"RadGridView Filter Dialog [{0}]";
                case RadGridStringId.CustomFilterDialogLabel: return "Mostre linhas aonde:";//Show rows where:";
                case RadGridStringId.CustomFilterDialogRbAnd: return "E";//And";
                case RadGridStringId.CustomFilterDialogRbOr: return "Ou";//Or";
                case RadGridStringId.CustomFilterDialogBtnOk: return "OK";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Cancelar";//Cancel";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "N�o";//Not";
                case RadGridStringId.CustomFilterDialogTrue: return "Verdadeiro";//True";
                case RadGridStringId.CustomFilterDialogFalse: return "Falso";//False";

                case RadGridStringId.FilterMenuAvailableFilters: return "Filtros dispon�veis";// Available Filters";
                case RadGridStringId.FilterMenuSearchBoxText: return "Procurar...";// Search...";
                case RadGridStringId.FilterMenuClearFilters: return "Limpar filtro";//Clear Filter";
                case RadGridStringId.FilterMenuButtonOK: return "OK";
                case RadGridStringId.FilterMenuButtonCancel: return "Cancelar";//Cancel";
                case RadGridStringId.FilterMenuSelectionAll: return "Tudo";//All";
                case RadGridStringId.FilterMenuSelectionAllSearched: return "Todos os resultados de pesquisa";//All Search Result";
                case RadGridStringId.FilterMenuSelectionNull: return "Nulo";//Null";
                case RadGridStringId.FilterMenuSelectionNotNull: return "N�o � nulo";//Not Null";

                case RadGridStringId.FilterFunctionSelectedDates: return "Filtrar entre dadas espec�ficas";// Filter by specific dates:";
                case RadGridStringId.FilterFunctionToday: return "Hoje";//Today";
                case RadGridStringId.FilterFunctionYesterday: return "Ontem";//Yesterday";
                case RadGridStringId.FilterFunctionDuringLast7days: return "Nos �ltimos 7 dias";// During last 7 days";

                case RadGridStringId.FilterLogicalOperatorAnd: return "E";//AND";
                case RadGridStringId.FilterLogicalOperatorOr: return "OU";//OR";
                case RadGridStringId.FilterCompositeNotOperator: return "N�O";//NOT";

                case RadGridStringId.DeleteRowMenuItem: return "Apagar linha";//Delete Row";
                case RadGridStringId.SortAscendingMenuItem: return "Ordenar ascendente";// Sort Ascending";
                case RadGridStringId.SortDescendingMenuItem: return "Ordenar descendente";//Sort Descending";
                case RadGridStringId.ClearSortingMenuItem: return "Limpar ordena��o";//Clear Sorting";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Formata��o condicional";//Conditional Formatting";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Agrupar por esta coluna";// Group by this column";
                case RadGridStringId.UngroupThisColumn: return "Desagrupar esta coluna";// Ungroup this column";
                case RadGridStringId.ColumnChooserMenuItem: return "Escoher coluna";// Column Chooser";
                case RadGridStringId.HideMenuItem: return "Ocultar coluna";//Hide Column";
                case RadGridStringId.HideGroupMenuItem: return "Ocultar grupo";//Hide Group";
                case RadGridStringId.UnpinMenuItem: return "Desfixar coluna";//Unpin Column";
                case RadGridStringId.UnpinRowMenuItem: return "Desfixar linha";//Unpin Row";
                case RadGridStringId.PinMenuItem: return "Status fixado";// Pinned state";
                case RadGridStringId.PinAtLeftMenuItem: return "Fixar � esquerda";// Pin at left";
                case RadGridStringId.PinAtRightMenuItem: return "Fixar � direita";//Pin at right";
                case RadGridStringId.PinAtBottomMenuItem: return "Fixar embaixo";//Pin at bottom";
                case RadGridStringId.PinAtTopMenuItem: return "Fixar no topo";//Pin at top";
                case RadGridStringId.BestFitMenuItem: return "Melhor adequa��o (Best fit)";//Best Fit";
                case RadGridStringId.PasteMenuItem: return "Colar";//Paste";
                case RadGridStringId.EditMenuItem: return "Editar";//Edit";
                case RadGridStringId.ClearValueMenuItem: return "Limpar valor";//Clear Value";
                case RadGridStringId.CopyMenuItem: return "Copiar";//Copy";
                case RadGridStringId.CutMenuItem: return "Recortar";//Cut";
                case RadGridStringId.AddNewRowString: return "Clique aqui para adiconar uma linha";// Click here to add a new row";
                case RadGridStringId.SearchRowResultsOfLabel: return "de";//of";
                case RadGridStringId.SearchRowMatchCase: return "Id�ntico";// Match case";
                case RadGridStringId.ConditionalFormattingSortAlphabetically: return "Ordene colunas em ordem alfab�tica";// Sort columns alphabetically";
                case RadGridStringId.ConditionalFormattingCaption: return "Gerenciador de Regras de Formata��o Condicional";// Conditional Formatting Rules Manager";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Formate somente c�lulas com";// Format only cells with";
                case RadGridStringId.ConditionalFormattingLblName: return "Nome da regra";//Rule name";
                case RadGridStringId.ConditionalFormattingLblType: return "Valor da c�lula";//Cell value";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Valor 1";//Value 1";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Valor 2";//Value 2";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Regras";//Rules";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Propriedade das regras";//Rule Properties";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Aplicar esta formata��o � linha inteira";// Apply this formatting to entire row";
                case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows: return "Aplicar esta formata��o se a linha estiver selecionada";// Apply this formatting if the row is selected";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Adiconar nova regra";// Add new rule";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Remover";//Remove";
                case RadGridStringId.ConditionalFormattingBtnOK: return "OK";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Cancelar";//Cancel";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Aplicar";//Apply";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Regra se aplica para";// Rule applies to";
                case RadGridStringId.ConditionalFormattingCondition: return "Condi��o";//Condition";
                case RadGridStringId.ConditionalFormattingExpression: return "Express�o";//Expression";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[Escolha um]";//[Choose one]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "Igual a [Value1]";//equals to [Value1]";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "n�o � igual para [Value1]";//is not equal to [Value1]";
                case RadGridStringId.ConditionalFormattingStartsWith: return "Come�a com [Value1]";//starts with [Value1]";
                case RadGridStringId.ConditionalFormattingEndsWith: return "Termina com [Value1]";//ends with [Value1]";
                case RadGridStringId.ConditionalFormattingContains: return "Cont�m [Value1]";//contains [Value1]
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "n�o cont�m [Value1]";// does not contain [Value1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "� maior que [Value1]";//is greater than [Value1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "� maior que ou igual a [Value1]";//is greater than or equal [Value1]";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "� menor que [Value1]";//is less than [Value1]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "� menor que ou igual a [Value1]";//is less than or equal to [Value1]";
                case RadGridStringId.ConditionalFormattingIsBetween: return "� entre [Value1] e [Value2]";//is between [Value1] and [Value2]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "n�o est� entre [Value1] e [Value2]";// is not between [Value1] and [Value1]";
                case RadGridStringId.ConditionalFormattingLblFormat: return "Formato";//Format";

                case RadGridStringId.ConditionalFormattingBtnExpression: return "Editor de express�es";// Expression editor";
                case RadGridStringId.ConditionalFormattingTextBoxExpression: return "Express�o";//Expression";

                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive: return "CasoSens�vel";// return "CaseSensitive";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor: return "CorFundoC�lula";// return "CellBackColor";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor: return "CorTextoC�lula"; // return "CellForeColor";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabled: return "Habilitado"; // "Enabled";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor: return "CorFundoLinha"; // "RowBackColor";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor: return "CorTextoLinha"; // "RowForeColor";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment: return "LinhaTextoAlinhamento"; // "RowTextAlignment";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment: return "AlinhamentoTexto"; // "TextAlignment";

                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription: return "Determina onde a compara��o de caso sens�vel ser� feita quando liberar o texto";// "Determines whether case-sensitive comparisons will be made when evaluating string values.";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription: return "Entre com o fundo de cor que ser� usado na c�lula"; // "Enter the background color to be used for the cell.";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription: return "Entre com a cor de texto que ser� usado na c�lula"; // "Enter the foreground color to be used for the cell.";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription: return "Determina quando a condi��o est� dispon�vel (pode ser liberado e aplicado)"; // Determines whether the condition is enabled (can be evaluated and applied).";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription: return "Entre com a cor de fundo da linha"; // "Enter the background color to be used for the entire row.";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription: return "Entre com a cor de texto da linha";// "Enter the foreground color to be used for the entire row.";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription: return "Entre com o alinhamento que sera usado nos valores, aplicado se for verdadeiro";// "Enter the alignment to be used for the cell values, when ApplyToRow is true.";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription: return "Entre com o alinhamento que ser� usado nos valores das c�lulas"; // "Enter the alignment to be used for the cell values.";

                case RadGridStringId.ColumnChooserFormCaption: return "Escolhedor de coluna";// Column Chooser";
                case RadGridStringId.ColumnChooserFormMessage: return "Arraste um cabe�alho da\ngrade aqui para remover da\nvisualiza��o atual"; // "Drag a column header from the\ngrid here to remove it from\nthe current view.";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Arraste a coluna aqui para agrupar essa coluna";//  "Drag a column here to group by this column.";
                case RadGridStringId.GroupingPanelHeader: return "Agrupar por";// Group by:";
                case RadGridStringId.PagingPanelPagesLabel: return "P�gina";//Page";
                case RadGridStringId.PagingPanelOfPagesLabel: return "de";//of";
                case RadGridStringId.NoDataText: return "Nenhuma informa��o para ser exibida";// No data to display";
                case RadGridStringId.CompositeFilterFormErrorCaption: return "Erro no filtro";// Filter Error";
                case RadGridStringId.CompositeFilterFormInvalidFilter: return "O descritor do filtro composto n�o � valido";// "The composite filter descriptor is not valid.";

                case RadGridStringId.ExpressionMenuItem: return "Express�o"; // "Expression";
                case RadGridStringId.ExpressionFormTitle: return "Construtor de express�es";// "Expression Builder";
                case RadGridStringId.ExpressionFormFunctions: return "Fun��es";// "Functions";
                case RadGridStringId.ExpressionFormFunctionsText: return "Texto";// "Text";
                case RadGridStringId.ExpressionFormFunctionsAggregate: return "Agregar";// "Aggregate";
                case RadGridStringId.ExpressionFormFunctionsDateTime: return "Data-Hora";// "Date-Time";
                case RadGridStringId.ExpressionFormFunctionsLogical: return "L�gico";// "Logical";
                case RadGridStringId.ExpressionFormFunctionsMath: return "Matem�tico (Math)";// "Math";
                case RadGridStringId.ExpressionFormFunctionsOther: return "Outro";// "Other";
                case RadGridStringId.ExpressionFormOperators: return "Operadores";// "Operators";
                case RadGridStringId.ExpressionFormConstants: return "Constantes";// "Constants";
                case RadGridStringId.ExpressionFormFields: return "Campos";// "Fields";
                case RadGridStringId.ExpressionFormDescription: return "Descri��o";// "Description";
                case RadGridStringId.ExpressionFormResultPreview: return "Visualiza��o do resultado";// "Result preview";
                case RadGridStringId.ExpressionFormTooltipPlus: return "Mais";// "Plus";
                case RadGridStringId.ExpressionFormTooltipMinus: return "Menos";// "Minus";
                case RadGridStringId.ExpressionFormTooltipMultiply: return "Multiplica";// "Multiply";
                case RadGridStringId.ExpressionFormTooltipDivide: return "Divide";// "Divide";
                case RadGridStringId.ExpressionFormTooltipModulo: return "M�dulo";// "Modulo";
                case RadGridStringId.ExpressionFormTooltipEqual: return "Igual";// "Equal";
                case RadGridStringId.ExpressionFormTooltipNotEqual: return "Diferente";// "Not Equal";
                case RadGridStringId.ExpressionFormTooltipLess: return "Menor";// "Less";
                case RadGridStringId.ExpressionFormTooltipLessOrEqual: return "Menor ou igual";//  "Less Or Equal";
                case RadGridStringId.ExpressionFormTooltipGreaterOrEqual: return "Maior que ou igual";//  "Greater Or Equal";
                case RadGridStringId.ExpressionFormTooltipGreater: return "Maior que";// "Greater";
                case RadGridStringId.ExpressionFormTooltipAnd: return "L�gico \"E\"";//"Logical \"AND\"";
                case RadGridStringId.ExpressionFormTooltipOr: return "L�GICO \"OU\"";//"Logical \"OR\"";
                case RadGridStringId.ExpressionFormTooltipNot: return "L�gico \"N�O\"";// "Logical \"NOT\"";
                case RadGridStringId.ExpressionFormAndButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOrButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormNotButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOKButton: return "OK";
                case RadGridStringId.ExpressionFormCancelButton: return "Cancelar";// "Cancel";
            }

            return string.Empty;
        }
    }
}
