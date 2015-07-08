namespace ePro.DB.eprocontext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate3 : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Product_Insert",
                p => new
                    {
                        ProductName = p.String(),
                        Source = p.String(),
                        ItemCode = p.String(),
                        Group = p.String(),
                        ABCClass = p.String(),
                        Status = p.String(),
                        ControlCode = p.String(),
                        Cond = p.String(),
                        Indicator = p.String(),
                        CyclicCode = p.String(),
                        UserGroup = p.String(),
                        UserGroup1 = p.String(),
                        ItemDescription = p.String(),
                        Description2 = p.String(),
                        Description3 = p.String(),
                        Unit = p.String(),
                        Weight = p.Int(),
                        Pack = p.String(),
                        PackQty = p.Int(),
                        Volume = p.Int(),
                        ConversionFactor = p.Int(),
                        AltUnitDesc = p.String(),
                        ItemGTIN = p.String(),
                        ModVAT = p.String(),
                        Trace = p.String(),
                        Storage = p.String(),
                        StandardCost = p.Decimal(precision: 18, scale: 2),
                        ReplacementCost = p.Decimal(precision: 18, scale: 2),
                        SalesCost = p.String(),
                        DutyPaidCost = p.String(),
                        InfoCost = p.String(),
                        ShelfLifeDays = p.String(),
                        WarrantyTypeFlag = p.String(),
                        DateLastChange = p.String(),
                        Per = p.String(),
                        ReorderPolicy = p.String(),
                        ReorderReview = p.String(),
                        ReorderBuyer = p.String(),
                        CreationDate = p.String(),
                        MovementCode = p.String(),
                        SalesType = p.String(),
                        SalesTaxPaidRate = p.String(),
                        SortCode = p.String(),
                        ExciseQty = p.String(),
                        UnSpscCode = p.String(),
                        AnalysisCode1 = p.String(),
                        AnalysisCode2 = p.String(),
                        AnalysisCode3 = p.String(),
                        SpareAnalysisCode = p.String(),
                        stkTallyCode = p.String(),
                        Brand = p.String(),
                        OriginFlag = p.String(),
                        OriginSource = p.String(),
                        PriceProtection = p.String(),
                        StkSpare1 = p.String(),
                        StkSpare2 = p.String(),
                        StkUserOnlyDate1 = p.String(),
                        StkUserOnlyDate2 = p.String(),
                        StkUserOnlyAlpha201 = p.String(),
                        StkUserOnlyAlpha202 = p.String(),
                        StkUserOnlyAlpha41 = p.String(),
                        StkUserOnlyAlpha42 = p.String(),
                        StkUserOnlyAlpha43 = p.String(),
                        StkUserOnlyAlpha44 = p.String(),
                        StkUserOnlyNum1 = p.Int(),
                        StkUserOnlyNum2 = p.Int(),
                        StkUserOnlyNum3 = p.Int(),
                        StkUserOnlyNum4 = p.Int(),
                        AddedDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[ProductListings]([ProductName], [Source], [ItemCode], [Group], [ABCClass], [Status], [ControlCode], [Cond], [Indicator], [CyclicCode], [UserGroup], [UserGroup1], [ItemDescription], [Description2], [Description3], [Unit], [Weight], [Pack], [PackQty], [Volume], [ConversionFactor], [AltUnitDesc], [ItemGTIN], [ModVAT], [Trace], [Storage], [StandardCost], [ReplacementCost], [SalesCost], [DutyPaidCost], [InfoCost], [ShelfLifeDays], [WarrantyTypeFlag], [DateLastChange], [Per], [ReorderPolicy], [ReorderReview], [ReorderBuyer], [CreationDate], [MovementCode], [SalesType], [SalesTaxPaidRate], [SortCode], [ExciseQty], [UnSpscCode], [AnalysisCode1], [AnalysisCode2], [AnalysisCode3], [SpareAnalysisCode], [stkTallyCode], [Brand], [OriginFlag], [OriginSource], [PriceProtection], [StkSpare1], [StkSpare2], [StkUserOnlyDate1], [StkUserOnlyDate2], [StkUserOnlyAlpha201], [StkUserOnlyAlpha202], [StkUserOnlyAlpha41], [StkUserOnlyAlpha42], [StkUserOnlyAlpha43], [StkUserOnlyAlpha44], [StkUserOnlyNum1], [StkUserOnlyNum2], [StkUserOnlyNum3], [StkUserOnlyNum4], [AddedDate], [Discriminator])
                      VALUES (@ProductName, @Source, @ItemCode, @Group, @ABCClass, @Status, @ControlCode, @Cond, @Indicator, @CyclicCode, @UserGroup, @UserGroup1, @ItemDescription, @Description2, @Description3, @Unit, @Weight, @Pack, @PackQty, @Volume, @ConversionFactor, @AltUnitDesc, @ItemGTIN, @ModVAT, @Trace, @Storage, @StandardCost, @ReplacementCost, @SalesCost, @DutyPaidCost, @InfoCost, @ShelfLifeDays, @WarrantyTypeFlag, @DateLastChange, @Per, @ReorderPolicy, @ReorderReview, @ReorderBuyer, @CreationDate, @MovementCode, @SalesType, @SalesTaxPaidRate, @SortCode, @ExciseQty, @UnSpscCode, @AnalysisCode1, @AnalysisCode2, @AnalysisCode3, @SpareAnalysisCode, @stkTallyCode, @Brand, @OriginFlag, @OriginSource, @PriceProtection, @StkSpare1, @StkSpare2, @StkUserOnlyDate1, @StkUserOnlyDate2, @StkUserOnlyAlpha201, @StkUserOnlyAlpha202, @StkUserOnlyAlpha41, @StkUserOnlyAlpha42, @StkUserOnlyAlpha43, @StkUserOnlyAlpha44, @StkUserOnlyNum1, @StkUserOnlyNum2, @StkUserOnlyNum3, @StkUserOnlyNum4, @AddedDate, N'Product')
                      
                      DECLARE @ProductListingID int
                      SELECT @ProductListingID = [ProductListingID]
                      FROM [dbo].[ProductListings]
                      WHERE @@ROWCOUNT > 0 AND [ProductListingID] = scope_identity()
                      
                      SELECT t0.[ProductListingID]
                      FROM [dbo].[ProductListings] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[ProductListingID] = @ProductListingID"
            );
            
            CreateStoredProcedure(
                "dbo.Product_Update",
                p => new
                    {
                        ProductListingID = p.Int(),
                        ProductName = p.String(),
                        Source = p.String(),
                        ItemCode = p.String(),
                        Group = p.String(),
                        ABCClass = p.String(),
                        Status = p.String(),
                        ControlCode = p.String(),
                        Cond = p.String(),
                        Indicator = p.String(),
                        CyclicCode = p.String(),
                        UserGroup = p.String(),
                        UserGroup1 = p.String(),
                        ItemDescription = p.String(),
                        Description2 = p.String(),
                        Description3 = p.String(),
                        Unit = p.String(),
                        Weight = p.Int(),
                        Pack = p.String(),
                        PackQty = p.Int(),
                        Volume = p.Int(),
                        ConversionFactor = p.Int(),
                        AltUnitDesc = p.String(),
                        ItemGTIN = p.String(),
                        ModVAT = p.String(),
                        Trace = p.String(),
                        Storage = p.String(),
                        StandardCost = p.Decimal(precision: 18, scale: 2),
                        ReplacementCost = p.Decimal(precision: 18, scale: 2),
                        SalesCost = p.String(),
                        DutyPaidCost = p.String(),
                        InfoCost = p.String(),
                        ShelfLifeDays = p.String(),
                        WarrantyTypeFlag = p.String(),
                        DateLastChange = p.String(),
                        Per = p.String(),
                        ReorderPolicy = p.String(),
                        ReorderReview = p.String(),
                        ReorderBuyer = p.String(),
                        CreationDate = p.String(),
                        MovementCode = p.String(),
                        SalesType = p.String(),
                        SalesTaxPaidRate = p.String(),
                        SortCode = p.String(),
                        ExciseQty = p.String(),
                        UnSpscCode = p.String(),
                        AnalysisCode1 = p.String(),
                        AnalysisCode2 = p.String(),
                        AnalysisCode3 = p.String(),
                        SpareAnalysisCode = p.String(),
                        stkTallyCode = p.String(),
                        Brand = p.String(),
                        OriginFlag = p.String(),
                        OriginSource = p.String(),
                        PriceProtection = p.String(),
                        StkSpare1 = p.String(),
                        StkSpare2 = p.String(),
                        StkUserOnlyDate1 = p.String(),
                        StkUserOnlyDate2 = p.String(),
                        StkUserOnlyAlpha201 = p.String(),
                        StkUserOnlyAlpha202 = p.String(),
                        StkUserOnlyAlpha41 = p.String(),
                        StkUserOnlyAlpha42 = p.String(),
                        StkUserOnlyAlpha43 = p.String(),
                        StkUserOnlyAlpha44 = p.String(),
                        StkUserOnlyNum1 = p.Int(),
                        StkUserOnlyNum2 = p.Int(),
                        StkUserOnlyNum3 = p.Int(),
                        StkUserOnlyNum4 = p.Int(),
                        AddedDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[ProductListings]
                      SET [ProductName] = @ProductName, [Source] = @Source, [ItemCode] = @ItemCode, [Group] = @Group, [ABCClass] = @ABCClass, [Status] = @Status, [ControlCode] = @ControlCode, [Cond] = @Cond, [Indicator] = @Indicator, [CyclicCode] = @CyclicCode, [UserGroup] = @UserGroup, [UserGroup1] = @UserGroup1, [ItemDescription] = @ItemDescription, [Description2] = @Description2, [Description3] = @Description3, [Unit] = @Unit, [Weight] = @Weight, [Pack] = @Pack, [PackQty] = @PackQty, [Volume] = @Volume, [ConversionFactor] = @ConversionFactor, [AltUnitDesc] = @AltUnitDesc, [ItemGTIN] = @ItemGTIN, [ModVAT] = @ModVAT, [Trace] = @Trace, [Storage] = @Storage, [StandardCost] = @StandardCost, [ReplacementCost] = @ReplacementCost, [SalesCost] = @SalesCost, [DutyPaidCost] = @DutyPaidCost, [InfoCost] = @InfoCost, [ShelfLifeDays] = @ShelfLifeDays, [WarrantyTypeFlag] = @WarrantyTypeFlag, [DateLastChange] = @DateLastChange, [Per] = @Per, [ReorderPolicy] = @ReorderPolicy, [ReorderReview] = @ReorderReview, [ReorderBuyer] = @ReorderBuyer, [CreationDate] = @CreationDate, [MovementCode] = @MovementCode, [SalesType] = @SalesType, [SalesTaxPaidRate] = @SalesTaxPaidRate, [SortCode] = @SortCode, [ExciseQty] = @ExciseQty, [UnSpscCode] = @UnSpscCode, [AnalysisCode1] = @AnalysisCode1, [AnalysisCode2] = @AnalysisCode2, [AnalysisCode3] = @AnalysisCode3, [SpareAnalysisCode] = @SpareAnalysisCode, [stkTallyCode] = @stkTallyCode, [Brand] = @Brand, [OriginFlag] = @OriginFlag, [OriginSource] = @OriginSource, [PriceProtection] = @PriceProtection, [StkSpare1] = @StkSpare1, [StkSpare2] = @StkSpare2, [StkUserOnlyDate1] = @StkUserOnlyDate1, [StkUserOnlyDate2] = @StkUserOnlyDate2, [StkUserOnlyAlpha201] = @StkUserOnlyAlpha201, [StkUserOnlyAlpha202] = @StkUserOnlyAlpha202, [StkUserOnlyAlpha41] = @StkUserOnlyAlpha41, [StkUserOnlyAlpha42] = @StkUserOnlyAlpha42, [StkUserOnlyAlpha43] = @StkUserOnlyAlpha43, [StkUserOnlyAlpha44] = @StkUserOnlyAlpha44, [StkUserOnlyNum1] = @StkUserOnlyNum1, [StkUserOnlyNum2] = @StkUserOnlyNum2, [StkUserOnlyNum3] = @StkUserOnlyNum3, [StkUserOnlyNum4] = @StkUserOnlyNum4, [AddedDate] = @AddedDate
                      WHERE ([ProductListingID] = @ProductListingID)"
            );
            
            CreateStoredProcedure(
                "dbo.Product_Delete",
                p => new
                    {
                        ProductListingID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ProductListings]
                      WHERE ([ProductListingID] = @ProductListingID)"
            );
            
            CreateStoredProcedure(
                "dbo.ProductListing_Insert",
                p => new
                    {
                        ProductName = p.String(),
                        Source = p.String(),
                        ItemCode = p.String(),
                        Group = p.String(),
                        ABCClass = p.String(),
                        Status = p.String(),
                        ControlCode = p.String(),
                        Cond = p.String(),
                        Indicator = p.String(),
                        CyclicCode = p.String(),
                        UserGroup = p.String(),
                        UserGroup1 = p.String(),
                        ItemDescription = p.String(),
                        Description2 = p.String(),
                        Description3 = p.String(),
                        Unit = p.String(),
                        Weight = p.Int(),
                        Pack = p.String(),
                        PackQty = p.Int(),
                        Volume = p.Int(),
                        ConversionFactor = p.Int(),
                        AltUnitDesc = p.String(),
                        ItemGTIN = p.String(),
                        ModVAT = p.String(),
                        Trace = p.String(),
                        Storage = p.String(),
                        StandardCost = p.Decimal(precision: 18, scale: 2),
                        ReplacementCost = p.Decimal(precision: 18, scale: 2),
                        SalesCost = p.String(),
                        DutyPaidCost = p.String(),
                        InfoCost = p.String(),
                        ShelfLifeDays = p.String(),
                        WarrantyTypeFlag = p.String(),
                        DateLastChange = p.String(),
                        Per = p.String(),
                        ReorderPolicy = p.String(),
                        ReorderReview = p.String(),
                        ReorderBuyer = p.String(),
                        CreationDate = p.String(),
                        MovementCode = p.String(),
                        SalesType = p.String(),
                        SalesTaxPaidRate = p.String(),
                        SortCode = p.String(),
                        ExciseQty = p.String(),
                        UnSpscCode = p.String(),
                        AnalysisCode1 = p.String(),
                        AnalysisCode2 = p.String(),
                        AnalysisCode3 = p.String(),
                        SpareAnalysisCode = p.String(),
                        stkTallyCode = p.String(),
                        Brand = p.String(),
                        OriginFlag = p.String(),
                        OriginSource = p.String(),
                        PriceProtection = p.String(),
                        StkSpare1 = p.String(),
                        StkSpare2 = p.String(),
                        StkUserOnlyDate1 = p.String(),
                        StkUserOnlyDate2 = p.String(),
                        StkUserOnlyAlpha201 = p.String(),
                        StkUserOnlyAlpha202 = p.String(),
                        StkUserOnlyAlpha41 = p.String(),
                        StkUserOnlyAlpha42 = p.String(),
                        StkUserOnlyAlpha43 = p.String(),
                        StkUserOnlyAlpha44 = p.String(),
                        StkUserOnlyNum1 = p.Int(),
                        StkUserOnlyNum2 = p.Int(),
                        StkUserOnlyNum3 = p.Int(),
                        StkUserOnlyNum4 = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[ProductListings]([ProductName], [Source], [ItemCode], [Group], [ABCClass], [Status], [ControlCode], [Cond], [Indicator], [CyclicCode], [UserGroup], [UserGroup1], [ItemDescription], [Description2], [Description3], [Unit], [Weight], [Pack], [PackQty], [Volume], [ConversionFactor], [AltUnitDesc], [ItemGTIN], [ModVAT], [Trace], [Storage], [StandardCost], [ReplacementCost], [SalesCost], [DutyPaidCost], [InfoCost], [ShelfLifeDays], [WarrantyTypeFlag], [DateLastChange], [Per], [ReorderPolicy], [ReorderReview], [ReorderBuyer], [CreationDate], [MovementCode], [SalesType], [SalesTaxPaidRate], [SortCode], [ExciseQty], [UnSpscCode], [AnalysisCode1], [AnalysisCode2], [AnalysisCode3], [SpareAnalysisCode], [stkTallyCode], [Brand], [OriginFlag], [OriginSource], [PriceProtection], [StkSpare1], [StkSpare2], [StkUserOnlyDate1], [StkUserOnlyDate2], [StkUserOnlyAlpha201], [StkUserOnlyAlpha202], [StkUserOnlyAlpha41], [StkUserOnlyAlpha42], [StkUserOnlyAlpha43], [StkUserOnlyAlpha44], [StkUserOnlyNum1], [StkUserOnlyNum2], [StkUserOnlyNum3], [StkUserOnlyNum4], [AddedDate], [Discriminator])
                      VALUES (@ProductName, @Source, @ItemCode, @Group, @ABCClass, @Status, @ControlCode, @Cond, @Indicator, @CyclicCode, @UserGroup, @UserGroup1, @ItemDescription, @Description2, @Description3, @Unit, @Weight, @Pack, @PackQty, @Volume, @ConversionFactor, @AltUnitDesc, @ItemGTIN, @ModVAT, @Trace, @Storage, @StandardCost, @ReplacementCost, @SalesCost, @DutyPaidCost, @InfoCost, @ShelfLifeDays, @WarrantyTypeFlag, @DateLastChange, @Per, @ReorderPolicy, @ReorderReview, @ReorderBuyer, @CreationDate, @MovementCode, @SalesType, @SalesTaxPaidRate, @SortCode, @ExciseQty, @UnSpscCode, @AnalysisCode1, @AnalysisCode2, @AnalysisCode3, @SpareAnalysisCode, @stkTallyCode, @Brand, @OriginFlag, @OriginSource, @PriceProtection, @StkSpare1, @StkSpare2, @StkUserOnlyDate1, @StkUserOnlyDate2, @StkUserOnlyAlpha201, @StkUserOnlyAlpha202, @StkUserOnlyAlpha41, @StkUserOnlyAlpha42, @StkUserOnlyAlpha43, @StkUserOnlyAlpha44, @StkUserOnlyNum1, @StkUserOnlyNum2, @StkUserOnlyNum3, @StkUserOnlyNum4, NULL, N'ProductListing')
                      
                      DECLARE @ProductListingID int
                      SELECT @ProductListingID = [ProductListingID]
                      FROM [dbo].[ProductListings]
                      WHERE @@ROWCOUNT > 0 AND [ProductListingID] = scope_identity()
                      
                      SELECT t0.[ProductListingID]
                      FROM [dbo].[ProductListings] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[ProductListingID] = @ProductListingID"
            );
            
            CreateStoredProcedure(
                "dbo.ProductListing_Update",
                p => new
                    {
                        ProductListingID = p.Int(),
                        ProductName = p.String(),
                        Source = p.String(),
                        ItemCode = p.String(),
                        Group = p.String(),
                        ABCClass = p.String(),
                        Status = p.String(),
                        ControlCode = p.String(),
                        Cond = p.String(),
                        Indicator = p.String(),
                        CyclicCode = p.String(),
                        UserGroup = p.String(),
                        UserGroup1 = p.String(),
                        ItemDescription = p.String(),
                        Description2 = p.String(),
                        Description3 = p.String(),
                        Unit = p.String(),
                        Weight = p.Int(),
                        Pack = p.String(),
                        PackQty = p.Int(),
                        Volume = p.Int(),
                        ConversionFactor = p.Int(),
                        AltUnitDesc = p.String(),
                        ItemGTIN = p.String(),
                        ModVAT = p.String(),
                        Trace = p.String(),
                        Storage = p.String(),
                        StandardCost = p.Decimal(precision: 18, scale: 2),
                        ReplacementCost = p.Decimal(precision: 18, scale: 2),
                        SalesCost = p.String(),
                        DutyPaidCost = p.String(),
                        InfoCost = p.String(),
                        ShelfLifeDays = p.String(),
                        WarrantyTypeFlag = p.String(),
                        DateLastChange = p.String(),
                        Per = p.String(),
                        ReorderPolicy = p.String(),
                        ReorderReview = p.String(),
                        ReorderBuyer = p.String(),
                        CreationDate = p.String(),
                        MovementCode = p.String(),
                        SalesType = p.String(),
                        SalesTaxPaidRate = p.String(),
                        SortCode = p.String(),
                        ExciseQty = p.String(),
                        UnSpscCode = p.String(),
                        AnalysisCode1 = p.String(),
                        AnalysisCode2 = p.String(),
                        AnalysisCode3 = p.String(),
                        SpareAnalysisCode = p.String(),
                        stkTallyCode = p.String(),
                        Brand = p.String(),
                        OriginFlag = p.String(),
                        OriginSource = p.String(),
                        PriceProtection = p.String(),
                        StkSpare1 = p.String(),
                        StkSpare2 = p.String(),
                        StkUserOnlyDate1 = p.String(),
                        StkUserOnlyDate2 = p.String(),
                        StkUserOnlyAlpha201 = p.String(),
                        StkUserOnlyAlpha202 = p.String(),
                        StkUserOnlyAlpha41 = p.String(),
                        StkUserOnlyAlpha42 = p.String(),
                        StkUserOnlyAlpha43 = p.String(),
                        StkUserOnlyAlpha44 = p.String(),
                        StkUserOnlyNum1 = p.Int(),
                        StkUserOnlyNum2 = p.Int(),
                        StkUserOnlyNum3 = p.Int(),
                        StkUserOnlyNum4 = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[ProductListings]
                      SET [ProductName] = @ProductName, [Source] = @Source, [ItemCode] = @ItemCode, [Group] = @Group, [ABCClass] = @ABCClass, [Status] = @Status, [ControlCode] = @ControlCode, [Cond] = @Cond, [Indicator] = @Indicator, [CyclicCode] = @CyclicCode, [UserGroup] = @UserGroup, [UserGroup1] = @UserGroup1, [ItemDescription] = @ItemDescription, [Description2] = @Description2, [Description3] = @Description3, [Unit] = @Unit, [Weight] = @Weight, [Pack] = @Pack, [PackQty] = @PackQty, [Volume] = @Volume, [ConversionFactor] = @ConversionFactor, [AltUnitDesc] = @AltUnitDesc, [ItemGTIN] = @ItemGTIN, [ModVAT] = @ModVAT, [Trace] = @Trace, [Storage] = @Storage, [StandardCost] = @StandardCost, [ReplacementCost] = @ReplacementCost, [SalesCost] = @SalesCost, [DutyPaidCost] = @DutyPaidCost, [InfoCost] = @InfoCost, [ShelfLifeDays] = @ShelfLifeDays, [WarrantyTypeFlag] = @WarrantyTypeFlag, [DateLastChange] = @DateLastChange, [Per] = @Per, [ReorderPolicy] = @ReorderPolicy, [ReorderReview] = @ReorderReview, [ReorderBuyer] = @ReorderBuyer, [CreationDate] = @CreationDate, [MovementCode] = @MovementCode, [SalesType] = @SalesType, [SalesTaxPaidRate] = @SalesTaxPaidRate, [SortCode] = @SortCode, [ExciseQty] = @ExciseQty, [UnSpscCode] = @UnSpscCode, [AnalysisCode1] = @AnalysisCode1, [AnalysisCode2] = @AnalysisCode2, [AnalysisCode3] = @AnalysisCode3, [SpareAnalysisCode] = @SpareAnalysisCode, [stkTallyCode] = @stkTallyCode, [Brand] = @Brand, [OriginFlag] = @OriginFlag, [OriginSource] = @OriginSource, [PriceProtection] = @PriceProtection, [StkSpare1] = @StkSpare1, [StkSpare2] = @StkSpare2, [StkUserOnlyDate1] = @StkUserOnlyDate1, [StkUserOnlyDate2] = @StkUserOnlyDate2, [StkUserOnlyAlpha201] = @StkUserOnlyAlpha201, [StkUserOnlyAlpha202] = @StkUserOnlyAlpha202, [StkUserOnlyAlpha41] = @StkUserOnlyAlpha41, [StkUserOnlyAlpha42] = @StkUserOnlyAlpha42, [StkUserOnlyAlpha43] = @StkUserOnlyAlpha43, [StkUserOnlyAlpha44] = @StkUserOnlyAlpha44, [StkUserOnlyNum1] = @StkUserOnlyNum1, [StkUserOnlyNum2] = @StkUserOnlyNum2, [StkUserOnlyNum3] = @StkUserOnlyNum3, [StkUserOnlyNum4] = @StkUserOnlyNum4
                      WHERE ([ProductListingID] = @ProductListingID)"
            );
            
            CreateStoredProcedure(
                "dbo.ProductListing_Delete",
                p => new
                    {
                        ProductListingID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[ProductListings]
                      WHERE ([ProductListingID] = @ProductListingID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.ProductListing_Delete");
            DropStoredProcedure("dbo.ProductListing_Update");
            DropStoredProcedure("dbo.ProductListing_Insert");
            DropStoredProcedure("dbo.Product_Delete");
            DropStoredProcedure("dbo.Product_Update");
            DropStoredProcedure("dbo.Product_Insert");
        }
    }
}
