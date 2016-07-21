using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMultiBlockDataGroupFilter : vtkMultiBlockDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockDataGroupFilter";

		public new static readonly string MRClassNameKey;

		static vtkMultiBlockDataGroupFilter()
		{
			vtkMultiBlockDataGroupFilter.MRClassNameKey = "class vtkMultiBlockDataGroupFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockDataGroupFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockDataGroupFilter"));
		}

		public vtkMultiBlockDataGroupFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockDataGroupFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiBlockDataGroupFilter New()
		{
			vtkMultiBlockDataGroupFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockDataGroupFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMultiBlockDataGroupFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMultiBlockDataGroupFilter_AddInput_01(HandleRef pThis, HandleRef arg0);

		public void AddInput(vtkDataObject arg0)
		{
			vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMultiBlockDataGroupFilter_AddInput_02(HandleRef pThis, int arg0, HandleRef arg1);

		public void AddInput(int arg0, vtkDataObject arg1)
		{
			vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_AddInput_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiBlockDataGroupFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiBlockDataGroupFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockDataGroupFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMultiBlockDataGroupFilter NewInstance()
		{
			vtkMultiBlockDataGroupFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockDataGroupFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockDataGroupFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiBlockDataGroupFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockDataGroupFilter vtkMultiBlockDataGroupFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataGroupFilter.vtkMultiBlockDataGroupFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataGroupFilter = (vtkMultiBlockDataGroupFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataGroupFilter.Register(null);
				}
			}
			return vtkMultiBlockDataGroupFilter;
		}
	}
}
