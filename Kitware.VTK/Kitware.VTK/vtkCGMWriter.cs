using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCGMWriter : vtkPolyDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCGMWriter";

		public new static readonly string MRClassNameKey;

		static vtkCGMWriter()
		{
			vtkCGMWriter.MRClassNameKey = "class vtkCGMWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCGMWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCGMWriter"));
		}

		public vtkCGMWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkCGMWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCGMWriter New()
		{
			vtkCGMWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCGMWriter.vtkCGMWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCGMWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCGMWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCGMWriter.vtkCGMWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkCGMWriter_GetColorMode_01(HandleRef pThis);

		public virtual int GetColorMode()
		{
			return vtkCGMWriter.vtkCGMWriter_GetColorMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkCGMWriter_GetResolution_02(HandleRef pThis);

		public virtual int GetResolution()
		{
			return vtkCGMWriter.vtkCGMWriter_GetResolution_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkCGMWriter_GetResolutionMaxValue_03(HandleRef pThis);

		public virtual int GetResolutionMaxValue()
		{
			return vtkCGMWriter.vtkCGMWriter_GetResolutionMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkCGMWriter_GetResolutionMinValue_04(HandleRef pThis);

		public virtual int GetResolutionMinValue()
		{
			return vtkCGMWriter.vtkCGMWriter_GetResolutionMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkCGMWriter_GetSort_05(HandleRef pThis);

		public virtual int GetSort()
		{
			return vtkCGMWriter.vtkCGMWriter_GetSort_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkCGMWriter_GetSpecifiedColor_06(HandleRef pThis);

		public virtual float[] GetSpecifiedColor()
		{
			IntPtr intPtr = vtkCGMWriter.vtkCGMWriter_GetSpecifiedColor_06(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkCGMWriter_GetSpecifiedColor_07(HandleRef pThis, IntPtr data);

		public virtual void GetSpecifiedColor(IntPtr data)
		{
			vtkCGMWriter.vtkCGMWriter_GetSpecifiedColor_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkCGMWriter_GetViewport_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkViewport GetViewport()
		{
			vtkViewport vtkViewport = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCGMWriter.vtkCGMWriter_GetViewport_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewport = (vtkViewport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewport.Register(null);
				}
			}
			return vtkViewport;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkCGMWriter_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCGMWriter.vtkCGMWriter_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkCGMWriter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCGMWriter.vtkCGMWriter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkCGMWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCGMWriter NewInstance()
		{
			vtkCGMWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCGMWriter.vtkCGMWriter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCGMWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkCGMWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCGMWriter SafeDownCast(vtkObjectBase o)
		{
			vtkCGMWriter vtkCGMWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCGMWriter.vtkCGMWriter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCGMWriter = (vtkCGMWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCGMWriter.Register(null);
				}
			}
			return vtkCGMWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkCGMWriter_SetColorMode_14(HandleRef pThis, int _arg);

		public virtual void SetColorMode(int _arg)
		{
			vtkCGMWriter.vtkCGMWriter_SetColorMode_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkCGMWriter_SetColorModeToDefault_15(HandleRef pThis);

		public void SetColorModeToDefault()
		{
			vtkCGMWriter.vtkCGMWriter_SetColorModeToDefault_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkCGMWriter_SetColorModeToRandomColors_16(HandleRef pThis);

		public void SetColorModeToRandomColors()
		{
			vtkCGMWriter.vtkCGMWriter_SetColorModeToRandomColors_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkCGMWriter_SetColorModeToSpecifiedColor_17(HandleRef pThis);

		public void SetColorModeToSpecifiedColor()
		{
			vtkCGMWriter.vtkCGMWriter_SetColorModeToSpecifiedColor_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkCGMWriter_SetResolution_18(HandleRef pThis, int _arg);

		public virtual void SetResolution(int _arg)
		{
			vtkCGMWriter.vtkCGMWriter_SetResolution_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkCGMWriter_SetSort_19(HandleRef pThis, int _arg);

		public virtual void SetSort(int _arg)
		{
			vtkCGMWriter.vtkCGMWriter_SetSort_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkCGMWriter_SetSpecifiedColor_20(HandleRef pThis, float _arg1, float _arg2, float _arg3);

		public virtual void SetSpecifiedColor(float _arg1, float _arg2, float _arg3)
		{
			vtkCGMWriter.vtkCGMWriter_SetSpecifiedColor_20(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkCGMWriter_SetSpecifiedColor_21(HandleRef pThis, IntPtr _arg);

		public virtual void SetSpecifiedColor(IntPtr _arg)
		{
			vtkCGMWriter.vtkCGMWriter_SetSpecifiedColor_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkCGMWriter_SetViewport_22(HandleRef pThis, HandleRef arg0);

		public virtual void SetViewport(vtkViewport arg0)
		{
			vtkCGMWriter.vtkCGMWriter_SetViewport_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
