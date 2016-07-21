using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMultiBlockMergeFilter : vtkMultiBlockDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockMergeFilter";

		public new static readonly string MRClassNameKey;

		static vtkMultiBlockMergeFilter()
		{
			vtkMultiBlockMergeFilter.MRClassNameKey = "class vtkMultiBlockMergeFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockMergeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockMergeFilter"));
		}

		public vtkMultiBlockMergeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockMergeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiBlockMergeFilter New()
		{
			vtkMultiBlockMergeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockMergeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMultiBlockMergeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMultiBlockMergeFilter_AddInput_01(HandleRef pThis, HandleRef arg0);

		public void AddInput(vtkDataObject arg0)
		{
			vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMultiBlockMergeFilter_AddInput_02(HandleRef pThis, int arg0, HandleRef arg1);

		public void AddInput(int arg0, vtkDataObject arg1)
		{
			vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_AddInput_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiBlockMergeFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiBlockMergeFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockMergeFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMultiBlockMergeFilter NewInstance()
		{
			vtkMultiBlockMergeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockMergeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockMergeFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiBlockMergeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockMergeFilter vtkMultiBlockMergeFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockMergeFilter.vtkMultiBlockMergeFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockMergeFilter = (vtkMultiBlockMergeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockMergeFilter.Register(null);
				}
			}
			return vtkMultiBlockMergeFilter;
		}
	}
}
