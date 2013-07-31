
using System;
using System.Collections.Generic;
using log4net;

public class BizCriteriaImpl {

	private readonly static ILog logger = LogManager.GetLogger(typeof(BizCriteriaImpl));

	public static void checkCanLoadCriteria() {
		List<int> agencyIds = ThreadContext.getContext().getUserAgencyIds();
		if (agencyIds.Contains((int)IExtranetBoConstants.ID_INT)) {
			BusinessRuleException.throwStandardBusinessException(ErrorMessage.GetString(
					"user_hasnt_load_user"), logger);
		}
	}

	public static void filterAdvertiserByUserRights(List<DomAdvertiser> advertisers) {
		if (advertisers != null && advertisers.Count != 0) {
			ThreadContext context = ThreadContext.getContext();
			List<int> abilities = context.getUserAbilities();

			if (abilities != null && abilities.Count != 0) {
				String advertiserCode;
				int abilitieCode;
				bool hasToRemove;
				for (int i = 0; i < advertisers.Count; i++) {
					hasToRemove = true;
					advertiserCode = advertisers[i].GetCode();
					for (int j = 0; j < abilities.Count; j++) {
						abilitieCode = abilities[j];

						if ((abilitieCode.ToString()).Equals(advertiserCode)) {
							hasToRemove = false;
							break;
						}
					}
					if (hasToRemove) {
						advertisers.RemoveAt(i);
						i--;
					}
				}
			}
		}
	}
}