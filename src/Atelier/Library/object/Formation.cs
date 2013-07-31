

using System;
using System.Data;

public class Formation {
	
	private long intId ;

	private long frmId;

	private  DateTime frmDateDebut;

	private DateTime frmDateFin;

	private String frmEcole = null;

	private String frmLieu = null;

	private String frmSpecialite = null;

	private String frmDiplome = null;

	private byte frmObtenu;

	private long tfoCode;

	private String tfoLibelle = null;

	public void populateFromRs(IDataReader res)  {
		intId = FactoryUtils.getLongValueFromRs(res, "INT_ID");
		frmId = FactoryUtils.getLongValueFromRs(res, "FRM_ID");
		frmDateDebut = (DateTime) FactoryUtils.getValueFromRs(res, "FRM_DATE_DEBUT");
		frmDateFin = (DateTime) FactoryUtils.getValueFromRs(res, "FRM_DATE_FIN");
		frmEcole = (String) FactoryUtils.getValueFromRs(res, "FRM_ECOLE");
		frmLieu = (String) FactoryUtils.getValueFromRs(res, "FRM_LIEU");
		frmSpecialite = (String) FactoryUtils.getValueFromRs(res, "FRM_SPECIALITE");
		frmDiplome = (String) FactoryUtils.getValueFromRs(res, "FRM_DIPLOME");
		frmObtenu = FactoryUtils.getByteValueFromRs(res, "FRM_OBTENU");
		tfoCode = FactoryUtils.getLongValueFromRs(res, "TFO_CODE");
		tfoLibelle = (String) FactoryUtils.getValueFromRs(res, "TFO_LIBELLE");
	}

	/**
	 * @return
	 */
	public DateTime getFrmDateDebut() {
		return frmDateDebut;
	}

	/**
	 * @return
	 */
	public DateTime getFrmDateFin() {
		return frmDateFin;
	}

	/**
	 * @return
	 */
	public String getFrmDiplome() {
		return frmDiplome;
	}

	/**
	 * @return
	 */
	public String getFrmEtablisssement() {
		return frmEcole;
	}

	/**
	 * @return
	 */
	public long getFrmId() {
		return frmId;
	}

	/**
	 * @return
	 */
	public String getFrmLieu() {
		return frmLieu;
	}

	/**
	 * @return
	 */
	public Byte getFrmObtenu() {
		return frmObtenu;
	}

	/**
	 * @return
	 */
	public String getFrmSpecialite() {
		return frmSpecialite;
	}

	/**
	 * @return
	 */
	public long getIntId() {
		return intId;
	}

	/**
	 * @return
	 */
	public long getTfoCode() {
		return tfoCode;
	}

	/**
	 * @param timestamp
	 */
	public void setFrmDateDebut(DateTime timestamp) {
		frmDateDebut = timestamp;
	}

	/**
	 * @param timestamp
	 */
	public void setFrmDateFin(DateTime
        timestamp) {
		frmDateFin = timestamp;
	}

	/**
	 * @param string
	 */
	public void setFrmDiplome(String @string) {
		frmDiplome = @string;
	}

	/**
	 * @param string
	 */
	public void setFrmEtablisssement(String @string) {
		frmEcole = @string;
	}

	/**
	 * @param decimal
	 */
	public void setFrmId(long @decimal) {
		frmId = @decimal;
	}

	/**
	 * @param string
	 */
	public void setFrmLieu(String @string) {
		frmLieu = @string;
	}

	/**
	 * @param decimal
	 */
	public void setFrmObtenu(Byte @decimal) {
		frmObtenu = @decimal;
	}

	/**
	 * @param string
	 */
	public void setFrmSpecialite(String @string) {
		frmSpecialite = @string;
	}

	/**
	 * @param decimal
	 */
	public void setIntId(long @decimal) {
		intId = @decimal;
	}

	/**
	 * @param decimal
	 */
	public void setTfoCode(long @decimal) {
		tfoCode = @decimal;
	}
}
