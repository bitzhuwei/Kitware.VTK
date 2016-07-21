using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetMapper : vtkMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetMapper";

		public new static readonly string MRClassNameKey;

		static vtkDataSetMapper()
		{
			vtkDataSetMapper.MRClassNameKey = "class vtkDataSetMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetMapper"));
		}

		public vtkDataSetMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetMapper New()
		{
			vtkDataSetMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetMapper.vtkDataSetMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataSetMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataSetMapper.vtkDataSetMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetMapper_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetMapper.vtkDataSetMapper_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkDataSetMapper_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkDataSetMapper.vtkDataSetMapper_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetMapper_GetPolyDataMapper_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPolyDataMapper GetPolyDataMapper()
		{
			vtkPolyDataMapper vtkPolyDataMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetMapper.vtkDataSetMapper_GetPolyDataMapper_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataMapper = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataMapper.Register(null);
				}
			}
			return vtkPolyDataMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDataSetMapper_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetMapper.vtkDataSetMapper_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDataSetMapper_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetMapper.vtkDataSetMapper_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetMapper NewInstance()
		{
			vtkDataSetMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetMapper.vtkDataSetMapper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataSetMapper_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkDataSetMapper.vtkDataSetMapper_ReleaseGraphicsResources_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataSetMapper_Render_09(HandleRef pThis, HandleRef ren, HandleRef act);

		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkDataSetMapper.vtkDataSetMapper_Render_09(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetMapper SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetMapper vtkDataSetMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetMapper.vtkDataSetMapper_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetMapper = (vtkDataSetMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetMapper.Register(null);
				}
			}
			return vtkDataSetMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataSetMapper_SetInput_11(HandleRef pThis, HandleRef input);

		public void SetInput(vtkDataSet input)
		{
			vtkDataSetMapper.vtkDataSetMapper_SetInput_11(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
