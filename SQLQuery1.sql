select tenders.*, Org.OrgTender, TypeTenders.Type, Currency.Currency, Category.Category from tenders
left join Org on Tenders.OrgId=Org.Id
left join Category on Tenders.CategoryID=Category.Id
left join TypeTenders on Tenders.TypeID=TypeTenders.Id
left join Currency on Tenders.CurrencyID=Currency.Id
order by tenders.Id
OFFSET 1 ROWS FETCH NEXT 5 ROWS ONLY