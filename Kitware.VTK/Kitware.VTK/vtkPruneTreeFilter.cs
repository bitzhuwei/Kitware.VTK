using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPruneTreeFilter : vtkTreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPruneTreeFilter";

		public new static readonly string MRClassNameKey;

		static vtkPruneTreeFilter()
		{
			vtkPruneTreeFilter.MRClassNameKey = "class vtkPruneTreeFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPruneTreeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPruneTreeFilter"));
		}

		public vtkPruneTreeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPruneTreeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPruneTreeFilter New()
		{
			vtkPruneTreeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPruneTreeFilter.vtkPruneTreeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPruneTreeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPruneTreeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPruneTreeFilter.vtkPruneTreeFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkPruneTreeFilter_GetParentVertex_01(HandleRef pThis);

		public virtual long GetParentVertex()
		{
			return vtkPruneTreeFilter.vtkPruneTreeFilter_GetParentVertex_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPruneTreeFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPruneTreeFilter.vtkPruneTreeFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPruneTreeFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPruneTreeFilter.vtkPruneTreeFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPruneTreeFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPruneTreeFilter NewInstance()
		{
			vtkPruneTreeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPruneTreeFilter.vtkPruneTreeFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPruneTreeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPruneTreeFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPruneTreeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPruneTreeFilter vtkPruneTreeFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPruneTreeFilter.vtkPruneTreeFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPruneTreeFilter = (vtkPruneTreeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPruneTreeFilter.Register(null);
				}
			}
			return vtkPruneTreeFilter;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPruneTreeFilter_SetParentVertex_07(HandleRef pThis, long _arg);

		public virtual void SetParentVertex(long _arg)
		{
			vtkPruneTreeFilter.vtkPruneTreeFilter_SetParentVertex_07(base.GetCppThis(), _arg);
		}
	}
}
