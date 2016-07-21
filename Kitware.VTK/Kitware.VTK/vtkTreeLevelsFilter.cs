using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeLevelsFilter : vtkTreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeLevelsFilter";

		public new static readonly string MRClassNameKey;

		static vtkTreeLevelsFilter()
		{
			vtkTreeLevelsFilter.MRClassNameKey = "class vtkTreeLevelsFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeLevelsFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeLevelsFilter"));
		}

		public vtkTreeLevelsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeLevelsFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeLevelsFilter New()
		{
			vtkTreeLevelsFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeLevelsFilter.vtkTreeLevelsFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeLevelsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeLevelsFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeLevelsFilter.vtkTreeLevelsFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeLevelsFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeLevelsFilter.vtkTreeLevelsFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeLevelsFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeLevelsFilter.vtkTreeLevelsFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeLevelsFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeLevelsFilter NewInstance()
		{
			vtkTreeLevelsFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeLevelsFilter.vtkTreeLevelsFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeLevelsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeLevelsFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeLevelsFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTreeLevelsFilter vtkTreeLevelsFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeLevelsFilter.vtkTreeLevelsFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeLevelsFilter = (vtkTreeLevelsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeLevelsFilter.Register(null);
				}
			}
			return vtkTreeLevelsFilter;
		}
	}
}
