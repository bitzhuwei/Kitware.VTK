using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkUnivariateStatisticsAlgorithm : vtkStatisticsAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnivariateStatisticsAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkUnivariateStatisticsAlgorithm()
		{
			vtkUnivariateStatisticsAlgorithm.MRClassNameKey = "class vtkUnivariateStatisticsAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnivariateStatisticsAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnivariateStatisticsAlgorithm"));
		}

		public vtkUnivariateStatisticsAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkUnivariateStatisticsAlgorithm_AddColumn_01(HandleRef pThis, string namCol);

		public void AddColumn(string namCol)
		{
			vtkUnivariateStatisticsAlgorithm.vtkUnivariateStatisticsAlgorithm_AddColumn_01(base.GetCppThis(), namCol);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkUnivariateStatisticsAlgorithm_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnivariateStatisticsAlgorithm.vtkUnivariateStatisticsAlgorithm_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkUnivariateStatisticsAlgorithm_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnivariateStatisticsAlgorithm.vtkUnivariateStatisticsAlgorithm_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkUnivariateStatisticsAlgorithm_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnivariateStatisticsAlgorithm NewInstance()
		{
			vtkUnivariateStatisticsAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnivariateStatisticsAlgorithm.vtkUnivariateStatisticsAlgorithm_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnivariateStatisticsAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkUnivariateStatisticsAlgorithm_RequestSelectedColumns_05(HandleRef pThis);

		public override int RequestSelectedColumns()
		{
			return vtkUnivariateStatisticsAlgorithm.vtkUnivariateStatisticsAlgorithm_RequestSelectedColumns_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkUnivariateStatisticsAlgorithm_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnivariateStatisticsAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkUnivariateStatisticsAlgorithm vtkUnivariateStatisticsAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnivariateStatisticsAlgorithm.vtkUnivariateStatisticsAlgorithm_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnivariateStatisticsAlgorithm = (vtkUnivariateStatisticsAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnivariateStatisticsAlgorithm.Register(null);
				}
			}
			return vtkUnivariateStatisticsAlgorithm;
		}
	}
}
