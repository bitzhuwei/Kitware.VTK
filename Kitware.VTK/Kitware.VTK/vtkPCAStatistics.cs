using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPCAStatistics : vtkMultiCorrelativeStatistics
	{
		public enum NormalizationType
		{
			DIAGONAL_SPECIFIED = 2,
			DIAGONAL_VARIANCE,
			NONE = 0,
			NUM_NORMALIZATION_SCHEMES = 4,
			TRIANGLE_SPECIFIED = 1
		}

		public enum ProjectionType
		{
			FIXED_BASIS_ENERGY = 2,
			FIXED_BASIS_SIZE = 1,
			FULL_BASIS = 0,
			NUM_BASIS_SCHEMES = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkPCAStatistics";

		public new static readonly string MRClassNameKey;

		static vtkPCAStatistics()
		{
			vtkPCAStatistics.MRClassNameKey = "class vtkPCAStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCAStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCAStatistics"));
		}

		public vtkPCAStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCAStatistics New()
		{
			vtkPCAStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCAStatistics.vtkPCAStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCAStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPCAStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPCAStatistics.vtkPCAStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPCAStatistics_GetBasisScheme_01(HandleRef pThis);

		public virtual int GetBasisScheme()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetBasisScheme_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAStatistics_GetBasisSchemeName_02(HandleRef pThis, int schemeIndex);

		public virtual string GetBasisSchemeName(int schemeIndex)
		{
			return Marshal.PtrToStringAnsi(vtkPCAStatistics.vtkPCAStatistics_GetBasisSchemeName_02(base.GetCppThis(), schemeIndex));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkPCAStatistics_GetEigenvalue_03(HandleRef pThis, int request, int i);

		public double GetEigenvalue(int request, int i)
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetEigenvalue_03(base.GetCppThis(), request, i);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkPCAStatistics_GetEigenvalue_04(HandleRef pThis, int i);

		public double GetEigenvalue(int i)
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetEigenvalue_04(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_GetEigenvalues_05(HandleRef pThis, int request, HandleRef arg1);

		public void GetEigenvalues(int request, vtkDoubleArray arg1)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvalues_05(base.GetCppThis(), request, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_GetEigenvalues_06(HandleRef pThis, HandleRef arg0);

		public void GetEigenvalues(vtkDoubleArray arg0)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvalues_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_GetEigenvector_07(HandleRef pThis, int i, HandleRef eigenvector);

		public void GetEigenvector(int i, vtkDoubleArray eigenvector)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvector_07(base.GetCppThis(), i, (eigenvector == null) ? default(HandleRef) : eigenvector.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_GetEigenvector_08(HandleRef pThis, int request, int i, HandleRef eigenvector);

		public void GetEigenvector(int request, int i, vtkDoubleArray eigenvector)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvector_08(base.GetCppThis(), request, i, (eigenvector == null) ? default(HandleRef) : eigenvector.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_GetEigenvectors_09(HandleRef pThis, int request, HandleRef eigenvectors);

		public void GetEigenvectors(int request, vtkDoubleArray eigenvectors)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvectors_09(base.GetCppThis(), request, (eigenvectors == null) ? default(HandleRef) : eigenvectors.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_GetEigenvectors_10(HandleRef pThis, HandleRef eigenvectors);

		public void GetEigenvectors(vtkDoubleArray eigenvectors)
		{
			vtkPCAStatistics.vtkPCAStatistics_GetEigenvectors_10(base.GetCppThis(), (eigenvectors == null) ? default(HandleRef) : eigenvectors.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkPCAStatistics_GetFixedBasisEnergy_11(HandleRef pThis);

		public virtual double GetFixedBasisEnergy()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetFixedBasisEnergy_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkPCAStatistics_GetFixedBasisEnergyMaxValue_12(HandleRef pThis);

		public virtual double GetFixedBasisEnergyMaxValue()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetFixedBasisEnergyMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkPCAStatistics_GetFixedBasisEnergyMinValue_13(HandleRef pThis);

		public virtual double GetFixedBasisEnergyMinValue()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetFixedBasisEnergyMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPCAStatistics_GetFixedBasisSize_14(HandleRef pThis);

		public virtual int GetFixedBasisSize()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetFixedBasisSize_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPCAStatistics_GetNormalizationScheme_15(HandleRef pThis);

		public virtual int GetNormalizationScheme()
		{
			return vtkPCAStatistics.vtkPCAStatistics_GetNormalizationScheme_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAStatistics_GetNormalizationSchemeName_16(HandleRef pThis, int scheme);

		public virtual string GetNormalizationSchemeName(int scheme)
		{
			return Marshal.PtrToStringAnsi(vtkPCAStatistics.vtkPCAStatistics_GetNormalizationSchemeName_16(base.GetCppThis(), scheme));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAStatistics_GetSpecifiedNormalization_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTable GetSpecifiedNormalization()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCAStatistics.vtkPCAStatistics_GetSpecifiedNormalization_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPCAStatistics_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPCAStatistics.vtkPCAStatistics_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPCAStatistics_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPCAStatistics.vtkPCAStatistics_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAStatistics_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPCAStatistics NewInstance()
		{
			vtkPCAStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCAStatistics.vtkPCAStatistics_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCAStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPCAStatistics_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPCAStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkPCAStatistics vtkPCAStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPCAStatistics.vtkPCAStatistics_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCAStatistics = (vtkPCAStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCAStatistics.Register(null);
				}
			}
			return vtkPCAStatistics;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_SetBasisScheme_23(HandleRef pThis, int _arg);

		public virtual void SetBasisScheme(int _arg)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetBasisScheme_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_SetBasisSchemeByName_24(HandleRef pThis, string schemeName);

		public virtual void SetBasisSchemeByName(string schemeName)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetBasisSchemeByName_24(base.GetCppThis(), schemeName);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_SetFixedBasisEnergy_25(HandleRef pThis, double _arg);

		public virtual void SetFixedBasisEnergy(double _arg)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetFixedBasisEnergy_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_SetFixedBasisSize_26(HandleRef pThis, int _arg);

		public virtual void SetFixedBasisSize(int _arg)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetFixedBasisSize_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_SetNormalizationScheme_27(HandleRef pThis, int _arg);

		public virtual void SetNormalizationScheme(int _arg)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetNormalizationScheme_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_SetNormalizationSchemeByName_28(HandleRef pThis, string sname);

		public virtual void SetNormalizationSchemeByName(string sname)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetNormalizationSchemeByName_28(base.GetCppThis(), sname);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPCAStatistics_SetSpecifiedNormalization_29(HandleRef pThis, HandleRef arg0);

		public virtual void SetSpecifiedNormalization(vtkTable arg0)
		{
			vtkPCAStatistics.vtkPCAStatistics_SetSpecifiedNormalization_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
