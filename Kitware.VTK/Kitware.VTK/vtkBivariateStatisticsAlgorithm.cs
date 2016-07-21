using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkBivariateStatisticsAlgorithm : vtkStatisticsAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBivariateStatisticsAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkBivariateStatisticsAlgorithm()
		{
			vtkBivariateStatisticsAlgorithm.MRClassNameKey = "class vtkBivariateStatisticsAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBivariateStatisticsAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBivariateStatisticsAlgorithm"));
		}

		public vtkBivariateStatisticsAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkBivariateStatisticsAlgorithm_AddColumnPair_01(HandleRef pThis, string namColX, string namColY);

		public void AddColumnPair(string namColX, string namColY)
		{
			vtkBivariateStatisticsAlgorithm.vtkBivariateStatisticsAlgorithm_AddColumnPair_01(base.GetCppThis(), namColX, namColY);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBivariateStatisticsAlgorithm_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBivariateStatisticsAlgorithm.vtkBivariateStatisticsAlgorithm_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBivariateStatisticsAlgorithm_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBivariateStatisticsAlgorithm.vtkBivariateStatisticsAlgorithm_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkBivariateStatisticsAlgorithm_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBivariateStatisticsAlgorithm NewInstance()
		{
			vtkBivariateStatisticsAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBivariateStatisticsAlgorithm.vtkBivariateStatisticsAlgorithm_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBivariateStatisticsAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkBivariateStatisticsAlgorithm_RequestSelectedColumns_05(HandleRef pThis);

		public override int RequestSelectedColumns()
		{
			return vtkBivariateStatisticsAlgorithm.vtkBivariateStatisticsAlgorithm_RequestSelectedColumns_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkBivariateStatisticsAlgorithm_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBivariateStatisticsAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkBivariateStatisticsAlgorithm vtkBivariateStatisticsAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBivariateStatisticsAlgorithm.vtkBivariateStatisticsAlgorithm_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBivariateStatisticsAlgorithm = (vtkBivariateStatisticsAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBivariateStatisticsAlgorithm.Register(null);
				}
			}
			return vtkBivariateStatisticsAlgorithm;
		}
	}
}
