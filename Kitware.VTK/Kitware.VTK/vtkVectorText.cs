using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVectorText : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVectorText";

		public new static readonly string MRClassNameKey;

		static vtkVectorText()
		{
			vtkVectorText.MRClassNameKey = "class vtkVectorText";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVectorText.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVectorText"));
		}

		public vtkVectorText(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVectorText_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVectorText New()
		{
			vtkVectorText result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVectorText.vtkVectorText_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorText)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVectorText() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVectorText.vtkVectorText_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVectorText_GetText_01(HandleRef pThis);

		public virtual string GetText()
		{
			return Marshal.PtrToStringAnsi(vtkVectorText.vtkVectorText_GetText_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVectorText_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVectorText.vtkVectorText_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVectorText_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVectorText.vtkVectorText_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVectorText_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVectorText NewInstance()
		{
			vtkVectorText result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVectorText.vtkVectorText_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorText)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVectorText_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVectorText SafeDownCast(vtkObjectBase o)
		{
			vtkVectorText vtkVectorText = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVectorText.vtkVectorText_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVectorText = (vtkVectorText)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVectorText.Register(null);
				}
			}
			return vtkVectorText;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVectorText_SetText_07(HandleRef pThis, string _arg);

		public virtual void SetText(string _arg)
		{
			vtkVectorText.vtkVectorText_SetText_07(base.GetCppThis(), _arg);
		}
	}
}
