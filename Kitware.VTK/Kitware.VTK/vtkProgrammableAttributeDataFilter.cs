using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProgrammableAttributeDataFilter : vtkDataSetAlgorithm
	{
		public delegate void ProgrammableMethodCallbackType(IntPtr arg0);

		public delegate void ExecuteMethodHandler(IntPtr arg);

		public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableAttributeDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkProgrammableAttributeDataFilter()
		{
			vtkProgrammableAttributeDataFilter.MRClassNameKey = "class vtkProgrammableAttributeDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgrammableAttributeDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableAttributeDataFilter"));
		}

		public vtkProgrammableAttributeDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableAttributeDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProgrammableAttributeDataFilter New()
		{
			vtkProgrammableAttributeDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProgrammableAttributeDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableAttributeDataFilter_AddInput_01(HandleRef pThis, HandleRef arg0);

		public new void AddInput(vtkDataSet arg0)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableAttributeDataFilter_GetInputList_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSetCollection GetInputList()
		{
			vtkDataSetCollection vtkDataSetCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_GetInputList_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetCollection = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetCollection.Register(null);
				}
			}
			return vtkDataSetCollection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProgrammableAttributeDataFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProgrammableAttributeDataFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableAttributeDataFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProgrammableAttributeDataFilter NewInstance()
		{
			vtkProgrammableAttributeDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableAttributeDataFilter_RemoveInput_07(HandleRef pThis, HandleRef arg0);

		public void RemoveInput(vtkDataSet arg0)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_RemoveInput_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableAttributeDataFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProgrammableAttributeDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkProgrammableAttributeDataFilter vtkProgrammableAttributeDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgrammableAttributeDataFilter = (vtkProgrammableAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgrammableAttributeDataFilter.Register(null);
				}
			}
			return vtkProgrammableAttributeDataFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableAttributeDataFilter_SetExecuteMethod_09(HandleRef pThis, vtkProgrammableAttributeDataFilter.ProgrammableMethodCallbackType f, IntPtr arg);

		public void SetExecuteMethod(vtkProgrammableAttributeDataFilter.ProgrammableMethodCallbackType f, IntPtr arg)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_SetExecuteMethod_09(base.GetCppThis(), f, arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableAttributeDataFilter_SetExecuteMethodArgDelete_10(HandleRef pThis, vtkProgrammableAttributeDataFilter.ProgrammableMethodCallbackType f);

		public void SetExecuteMethodArgDelete(vtkProgrammableAttributeDataFilter.ProgrammableMethodCallbackType f)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_SetExecuteMethodArgDelete_10(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableAttributeDataFilter_SetExecuteMethod(HandleRef pThis, vtkProgrammableAttributeDataFilter.ExecuteMethodHandler handler, IntPtr arg);

		public void SetExecuteMethod(vtkProgrammableAttributeDataFilter.ExecuteMethodHandler handler, IntPtr arg)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_SetExecuteMethod(base.GetCppThis(), handler, arg);
		}

		public void SetExecuteMethod(vtkProgrammableAttributeDataFilter.ExecuteMethodHandler handler)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_SetExecuteMethod(base.GetCppThis(), handler, IntPtr.Zero);
		}
	}
}
