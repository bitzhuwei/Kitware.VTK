using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageAppend : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAppend";

		public new static readonly string MRClassNameKey;

		static vtkImageAppend()
		{
			vtkImageAppend.MRClassNameKey = "class vtkImageAppend";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAppend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAppend"));
		}

		public vtkImageAppend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAppend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageAppend New()
		{
			vtkImageAppend result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAppend.vtkImageAppend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAppend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageAppend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageAppend.vtkImageAppend_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAppend_GetAppendAxis_01(HandleRef pThis);

		public virtual int GetAppendAxis()
		{
			return vtkImageAppend.vtkImageAppend_GetAppendAxis_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAppend_GetInput_02(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObject GetInput(int num)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAppend.vtkImageAppend_GetInput_02(base.GetCppThis(), num, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAppend_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAppend.vtkImageAppend_GetInput_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAppend_GetNumberOfInputs_04(HandleRef pThis);

		public int GetNumberOfInputs()
		{
			return vtkImageAppend.vtkImageAppend_GetNumberOfInputs_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAppend_GetPreserveExtents_05(HandleRef pThis);

		public virtual int GetPreserveExtents()
		{
			return vtkImageAppend.vtkImageAppend_GetPreserveExtents_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAppend_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageAppend.vtkImageAppend_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAppend_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageAppend.vtkImageAppend_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAppend_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageAppend NewInstance()
		{
			vtkImageAppend result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAppend.vtkImageAppend_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAppend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAppend_PreserveExtentsOff_10(HandleRef pThis);

		public virtual void PreserveExtentsOff()
		{
			vtkImageAppend.vtkImageAppend_PreserveExtentsOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAppend_PreserveExtentsOn_11(HandleRef pThis);

		public virtual void PreserveExtentsOn()
		{
			vtkImageAppend.vtkImageAppend_PreserveExtentsOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAppend_ReplaceNthInputConnection_12(HandleRef pThis, int idx, HandleRef input);

		public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
		{
			vtkImageAppend.vtkImageAppend_ReplaceNthInputConnection_12(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAppend_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageAppend SafeDownCast(vtkObjectBase o)
		{
			vtkImageAppend vtkImageAppend = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAppend.vtkImageAppend_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAppend = (vtkImageAppend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAppend.Register(null);
				}
			}
			return vtkImageAppend;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAppend_SetAppendAxis_14(HandleRef pThis, int _arg);

		public virtual void SetAppendAxis(int _arg)
		{
			vtkImageAppend.vtkImageAppend_SetAppendAxis_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAppend_SetInput_15(HandleRef pThis, int num, HandleRef input);

		public new void SetInput(int num, vtkDataObject input)
		{
			vtkImageAppend.vtkImageAppend_SetInput_15(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAppend_SetInput_16(HandleRef pThis, HandleRef input);

		public new void SetInput(vtkDataObject input)
		{
			vtkImageAppend.vtkImageAppend_SetInput_16(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAppend_SetPreserveExtents_17(HandleRef pThis, int _arg);

		public virtual void SetPreserveExtents(int _arg)
		{
			vtkImageAppend.vtkImageAppend_SetPreserveExtents_17(base.GetCppThis(), _arg);
		}
	}
}
