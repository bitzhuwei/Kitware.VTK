using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitTextureCoords : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitTextureCoords";

		public new static readonly string MRClassNameKey;

		static vtkImplicitTextureCoords()
		{
			vtkImplicitTextureCoords.MRClassNameKey = "class vtkImplicitTextureCoords";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitTextureCoords.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitTextureCoords"));
		}

		public vtkImplicitTextureCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitTextureCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitTextureCoords New()
		{
			vtkImplicitTextureCoords result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitTextureCoords() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitTextureCoords.vtkImplicitTextureCoords_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImplicitTextureCoords_FlipTextureOff_01(HandleRef pThis);

		public virtual void FlipTextureOff()
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_FlipTextureOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImplicitTextureCoords_FlipTextureOn_02(HandleRef pThis);

		public virtual void FlipTextureOn()
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_FlipTextureOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImplicitTextureCoords_GetFlipTexture_03(HandleRef pThis);

		public virtual int GetFlipTexture()
		{
			return vtkImplicitTextureCoords.vtkImplicitTextureCoords_GetFlipTexture_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitTextureCoords_GetRFunction_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetRFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_GetRFunction_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitTextureCoords_GetSFunction_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetSFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_GetSFunction_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitTextureCoords_GetTFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetTFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_GetTFunction_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImplicitTextureCoords_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitTextureCoords.vtkImplicitTextureCoords_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImplicitTextureCoords_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitTextureCoords.vtkImplicitTextureCoords_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitTextureCoords_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitTextureCoords NewInstance()
		{
			vtkImplicitTextureCoords result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitTextureCoords_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitTextureCoords SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitTextureCoords vtkImplicitTextureCoords = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitTextureCoords.vtkImplicitTextureCoords_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitTextureCoords = (vtkImplicitTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitTextureCoords.Register(null);
				}
			}
			return vtkImplicitTextureCoords;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImplicitTextureCoords_SetFlipTexture_12(HandleRef pThis, int _arg);

		public virtual void SetFlipTexture(int _arg)
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_SetFlipTexture_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImplicitTextureCoords_SetRFunction_13(HandleRef pThis, HandleRef arg0);

		public virtual void SetRFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_SetRFunction_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImplicitTextureCoords_SetSFunction_14(HandleRef pThis, HandleRef arg0);

		public virtual void SetSFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_SetSFunction_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImplicitTextureCoords_SetTFunction_15(HandleRef pThis, HandleRef arg0);

		public virtual void SetTFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitTextureCoords.vtkImplicitTextureCoords_SetTFunction_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
