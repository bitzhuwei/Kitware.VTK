using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositePolyDataMapper2 : vtkPainterPolyDataMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositePolyDataMapper2";

		public new static readonly string MRClassNameKey;

		static vtkCompositePolyDataMapper2()
		{
			vtkCompositePolyDataMapper2.MRClassNameKey = "class vtkCompositePolyDataMapper2";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositePolyDataMapper2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositePolyDataMapper2"));
		}

		public vtkCompositePolyDataMapper2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositePolyDataMapper2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositePolyDataMapper2 New()
		{
			vtkCompositePolyDataMapper2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositePolyDataMapper2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompositePolyDataMapper2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCompositePolyDataMapper2_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCompositePolyDataMapper2_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositePolyDataMapper2_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositePolyDataMapper2 NewInstance()
		{
			vtkCompositePolyDataMapper2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositePolyDataMapper2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositePolyDataMapper2_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositePolyDataMapper2 SafeDownCast(vtkObjectBase o)
		{
			vtkCompositePolyDataMapper2 vtkCompositePolyDataMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositePolyDataMapper2.vtkCompositePolyDataMapper2_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositePolyDataMapper = (vtkCompositePolyDataMapper2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositePolyDataMapper.Register(null);
				}
			}
			return vtkCompositePolyDataMapper;
		}
	}
}
