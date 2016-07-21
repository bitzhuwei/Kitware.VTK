using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageBlend : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageBlend";

		public new static readonly string MRClassNameKey;

		static vtkImageBlend()
		{
			vtkImageBlend.MRClassNameKey = "class vtkImageBlend";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageBlend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageBlend"));
		}

		public vtkImageBlend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageBlend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageBlend New()
		{
			vtkImageBlend result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageBlend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageBlend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageBlend.vtkImageBlend_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageBlend_GetBlendMode_01(HandleRef pThis);

		public virtual int GetBlendMode()
		{
			return vtkImageBlend.vtkImageBlend_GetBlendMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageBlend_GetBlendModeAsString_02(HandleRef pThis);

		public string GetBlendModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkImageBlend.vtkImageBlend_GetBlendModeAsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageBlend_GetBlendModeMaxValue_03(HandleRef pThis);

		public virtual int GetBlendModeMaxValue()
		{
			return vtkImageBlend.vtkImageBlend_GetBlendModeMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageBlend_GetBlendModeMinValue_04(HandleRef pThis);

		public virtual int GetBlendModeMinValue()
		{
			return vtkImageBlend.vtkImageBlend_GetBlendModeMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageBlend_GetCompoundThreshold_05(HandleRef pThis);

		public virtual double GetCompoundThreshold()
		{
			return vtkImageBlend.vtkImageBlend_GetCompoundThreshold_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageBlend_GetInput_06(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObject GetInput(int num)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_GetInput_06(base.GetCppThis(), num, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImageBlend_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_GetInput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImageBlend_GetNumberOfInputs_08(HandleRef pThis);

		public int GetNumberOfInputs()
		{
			return vtkImageBlend.vtkImageBlend_GetNumberOfInputs_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageBlend_GetOpacity_09(HandleRef pThis, int idx);

		public double GetOpacity(int idx)
		{
			return vtkImageBlend.vtkImageBlend_GetOpacity_09(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageBlend_GetStencil_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageStencilData GetStencil()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_GetStencil_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageBlend_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageBlend.vtkImageBlend_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageBlend_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageBlend.vtkImageBlend_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageBlend_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageBlend NewInstance()
		{
			vtkImageBlend result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageBlend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageBlend_ReplaceNthInputConnection_15(HandleRef pThis, int idx, HandleRef input);

		public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
		{
			vtkImageBlend.vtkImageBlend_ReplaceNthInputConnection_15(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageBlend_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageBlend SafeDownCast(vtkObjectBase o)
		{
			vtkImageBlend vtkImageBlend = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageBlend.vtkImageBlend_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageBlend = (vtkImageBlend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageBlend.Register(null);
				}
			}
			return vtkImageBlend;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageBlend_SetBlendMode_17(HandleRef pThis, int _arg);

		public virtual void SetBlendMode(int _arg)
		{
			vtkImageBlend.vtkImageBlend_SetBlendMode_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageBlend_SetBlendModeToCompound_18(HandleRef pThis);

		public void SetBlendModeToCompound()
		{
			vtkImageBlend.vtkImageBlend_SetBlendModeToCompound_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageBlend_SetBlendModeToNormal_19(HandleRef pThis);

		public void SetBlendModeToNormal()
		{
			vtkImageBlend.vtkImageBlend_SetBlendModeToNormal_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageBlend_SetCompoundThreshold_20(HandleRef pThis, double _arg);

		public virtual void SetCompoundThreshold(double _arg)
		{
			vtkImageBlend.vtkImageBlend_SetCompoundThreshold_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageBlend_SetInput_21(HandleRef pThis, int num, HandleRef input);

		public new void SetInput(int num, vtkDataObject input)
		{
			vtkImageBlend.vtkImageBlend_SetInput_21(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageBlend_SetInput_22(HandleRef pThis, HandleRef input);

		public new void SetInput(vtkDataObject input)
		{
			vtkImageBlend.vtkImageBlend_SetInput_22(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageBlend_SetOpacity_23(HandleRef pThis, int idx, double opacity);

		public void SetOpacity(int idx, double opacity)
		{
			vtkImageBlend.vtkImageBlend_SetOpacity_23(base.GetCppThis(), idx, opacity);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageBlend_SetStencil_24(HandleRef pThis, HandleRef stencil);

		public void SetStencil(vtkImageStencilData stencil)
		{
			vtkImageBlend.vtkImageBlend_SetStencil_24(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}
	}
}
