using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOutlineCornerSource : vtkOutlineSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineCornerSource";

		public new static readonly string MRClassNameKey;

		static vtkOutlineCornerSource()
		{
			vtkOutlineCornerSource.MRClassNameKey = "class vtkOutlineCornerSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutlineCornerSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineCornerSource"));
		}

		public vtkOutlineCornerSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineCornerSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutlineCornerSource New()
		{
			vtkOutlineCornerSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineCornerSource.vtkOutlineCornerSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineCornerSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOutlineCornerSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOutlineCornerSource.vtkOutlineCornerSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkOutlineCornerSource_GetCornerFactor_01(HandleRef pThis);

		public virtual double GetCornerFactor()
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_GetCornerFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkOutlineCornerSource_GetCornerFactorMaxValue_02(HandleRef pThis);

		public virtual double GetCornerFactorMaxValue()
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_GetCornerFactorMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkOutlineCornerSource_GetCornerFactorMinValue_03(HandleRef pThis);

		public virtual double GetCornerFactorMinValue()
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_GetCornerFactorMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineCornerSource_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineCornerSource_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOutlineCornerSource.vtkOutlineCornerSource_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineCornerSource_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOutlineCornerSource NewInstance()
		{
			vtkOutlineCornerSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineCornerSource.vtkOutlineCornerSource_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineCornerSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineCornerSource_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutlineCornerSource SafeDownCast(vtkObjectBase o)
		{
			vtkOutlineCornerSource vtkOutlineCornerSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineCornerSource.vtkOutlineCornerSource_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutlineCornerSource = (vtkOutlineCornerSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutlineCornerSource.Register(null);
				}
			}
			return vtkOutlineCornerSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineCornerSource_SetCornerFactor_09(HandleRef pThis, double _arg);

		public virtual void SetCornerFactor(double _arg)
		{
			vtkOutlineCornerSource.vtkOutlineCornerSource_SetCornerFactor_09(base.GetCppThis(), _arg);
		}
	}
}
