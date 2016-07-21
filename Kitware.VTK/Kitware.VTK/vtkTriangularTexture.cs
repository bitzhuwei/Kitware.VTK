using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTriangularTexture : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriangularTexture";

		public new static readonly string MRClassNameKey;

		static vtkTriangularTexture()
		{
			vtkTriangularTexture.MRClassNameKey = "class vtkTriangularTexture";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriangularTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangularTexture"));
		}

		public vtkTriangularTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangularTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTriangularTexture New()
		{
			vtkTriangularTexture result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangularTexture.vtkTriangularTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangularTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTriangularTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTriangularTexture.vtkTriangularTexture_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkTriangularTexture_GetScaleFactor_01(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetScaleFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkTriangularTexture_GetTexturePattern_02(HandleRef pThis);

		public virtual int GetTexturePattern()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetTexturePattern_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkTriangularTexture_GetTexturePatternMaxValue_03(HandleRef pThis);

		public virtual int GetTexturePatternMaxValue()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetTexturePatternMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkTriangularTexture_GetTexturePatternMinValue_04(HandleRef pThis);

		public virtual int GetTexturePatternMinValue()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetTexturePatternMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkTriangularTexture_GetXSize_05(HandleRef pThis);

		public virtual int GetXSize()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetXSize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkTriangularTexture_GetYSize_06(HandleRef pThis);

		public virtual int GetYSize()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetYSize_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkTriangularTexture_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTriangularTexture.vtkTriangularTexture_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkTriangularTexture_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTriangularTexture.vtkTriangularTexture_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangularTexture_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTriangularTexture NewInstance()
		{
			vtkTriangularTexture result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangularTexture.vtkTriangularTexture_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangularTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangularTexture_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTriangularTexture SafeDownCast(vtkObjectBase o)
		{
			vtkTriangularTexture vtkTriangularTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangularTexture.vtkTriangularTexture_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriangularTexture = (vtkTriangularTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriangularTexture.Register(null);
				}
			}
			return vtkTriangularTexture;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkTriangularTexture_SetScaleFactor_12(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkTriangularTexture.vtkTriangularTexture_SetScaleFactor_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkTriangularTexture_SetTexturePattern_13(HandleRef pThis, int _arg);

		public virtual void SetTexturePattern(int _arg)
		{
			vtkTriangularTexture.vtkTriangularTexture_SetTexturePattern_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkTriangularTexture_SetXSize_14(HandleRef pThis, int _arg);

		public virtual void SetXSize(int _arg)
		{
			vtkTriangularTexture.vtkTriangularTexture_SetXSize_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkTriangularTexture_SetYSize_15(HandleRef pThis, int _arg);

		public virtual void SetYSize(int _arg)
		{
			vtkTriangularTexture.vtkTriangularTexture_SetYSize_15(base.GetCppThis(), _arg);
		}
	}
}
